using Microsoft.Data.SqlClient;
using System.Configuration;

namespace TEST.Properties.Сlasses
{
    internal class AuthenticationService
    {
        private string connectionString;

        // Получаем строку подключения из конфига
        public AuthenticationService()
        {
            // Подключение к базе данных
            connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        }

        // Класс проверки соответствия имени и пароля с данным базы данных
        public bool ValidateUser(string username, string password)
        {
            bool isValid = false;

            string query = "SELECT COUNT(1) FROM UserLogin WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        isValid = (count > 0);
                    }
                }
                catch (SqlException ex)
                {
                    // Ошибка базы данных
                    Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    throw; 
                }
            }

            return isValid;
        }
    }
}
    

