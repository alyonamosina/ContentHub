using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Marketing.Properties.Сlasses
{
    // Добавление записи
    public class ContentAdder
    {
        public void Add(string title, string author, string description,
                       string type, string platform, DateTime date, int views)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Content (Title, Author, Description, Type, Platform, Publication_date, Views) " +
                               "VALUES (@Title, @Author, @Description, @Type, @Platform, @Date, @Views)";

                SqlCommand command = new SqlCommand(query, connection);

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
