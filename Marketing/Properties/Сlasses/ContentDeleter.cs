using Microsoft.Data.SqlClient;
using System.Configuration;

namespace TEST.Properties.Сlasses
{
    public class ContentDeleter
    {
        public void Delete(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Content WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
