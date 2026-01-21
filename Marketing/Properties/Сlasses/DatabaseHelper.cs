using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace TEST.Properties.Сlasses
{
    public static class DatabaseHelper
    {
        // Вывод всей таблицы
        public static DataTable LoadAllContent() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Content";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Поиск по всем столбцам
        public static DataTable SearchContent(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return LoadAllContent(); // Если поиск пустой, возвращаем все
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT * FROM Content
                WHERE 
                    Title LIKE @search OR
                    Author LIKE @search OR
                    Description LIKE @search OR
                    Type LIKE @search OR
                    Platform LIKE @search OR
                    CONVERT(varchar, Publication_date, 105) LIKE @search OR
                    CONVERT(varchar, Views) LIKE @search";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@search", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

    }

    // Получение данных конкретной записи из базы данных
    public class ContentReader
    {
        public DataRow GetContentById(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Указываем все столбцы
                string query = "SELECT Id, Title, Author, Description, Type, Platform, Publication_date, Views FROM Content WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }

            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }
    }
}
