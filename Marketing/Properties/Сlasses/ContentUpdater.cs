using Microsoft.Data.SqlClient;
using System.Configuration;

namespace TEST.Properties.Сlasses
{
    public class ContentUpdater
    {
        //Функция для обновления записи в базе данных
        public void Update(int id, string title, string author, string description,
                          string type, string platform, DateTime date, int views)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Content SET 
                               Title = @Title, 
                               Author = @Author, 
                               Description = @Description, 
                               Type = @Type, 
                               Platform = @Platform, 
                               Publication_date = @Date, 
                               Views = @Views 
                               WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Platform", platform);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Views", views);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
