using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TEST.Properties.Сlasses
{
    public class SearchEngine
        {
            private string connectionString;

            public SearchEngine()
            {
                // Получаем строку подключения из конфигурационного файла
                this.connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
            }

            public DataTable SearchContent(
                string title = null,
                string author = null,
                string description = null,
                string type = null,
                string platform = null,
                string publicationDate = null,
                string views = null)
            {
                DataTable result = new DataTable();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Создаем базовый запрос
                        string query = @"
                        SELECT Title, Author, Description, Type, Platform, 
                               Publication_date, Views 
                        FROM Content 
                        WHERE 1=1";

                        // Динамически добавляем условия, если параметры заполнены
                        if (!string.IsNullOrWhiteSpace(title))
                        {
                            query += " AND Title LIKE @Title";
                        }
                        if (!string.IsNullOrWhiteSpace(author))
                        {
                            query += " AND Author LIKE @Author";
                        }
                        if (!string.IsNullOrWhiteSpace(description))
                        {
                            query += " AND Description LIKE @Description";
                        }
                        if (!string.IsNullOrWhiteSpace(type))
                        {
                            query += " AND Type = @Type";
                        }
                        if (!string.IsNullOrWhiteSpace(platform))
                        {
                            query += " AND Platform = @Platform";
                        }
                        if (!string.IsNullOrWhiteSpace(publicationDate))
                        {
                            query += " AND CONVERT(date, Publication_date) = @PublicationDate";
                        }
                        if (!string.IsNullOrWhiteSpace(views))
                        {
                            query += " AND Views >= @Views";
                        }

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Добавляем параметры только если они не пустые
                            if (!string.IsNullOrWhiteSpace(title))
                            {
                                command.Parameters.AddWithValue("@Title", "%" + title + "%");
                            }
                            if (!string.IsNullOrWhiteSpace(author))
                            {
                                command.Parameters.AddWithValue("@Author", "%" + author + "%");
                            }
                            if (!string.IsNullOrWhiteSpace(description))
                            {
                                command.Parameters.AddWithValue("@Description", "%" + description + "%");
                            }
                            if (!string.IsNullOrWhiteSpace(type))
                            {
                                command.Parameters.AddWithValue("@Type", type);
                            }
                            if (!string.IsNullOrWhiteSpace(platform))
                            {
                                command.Parameters.AddWithValue("@Platform", platform);
                            }
                            if (!string.IsNullOrWhiteSpace(publicationDate))
                            {
                                command.Parameters.AddWithValue("@PublicationDate", publicationDate);
                            }
                            if (!string.IsNullOrWhiteSpace(views))
                            {
                                // Безопасная проверка на число
                                if (int.TryParse(views, out int viewsValue))
                                {
                                    command.Parameters.AddWithValue("@Views", viewsValue);
                                }
                            }

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(result);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return result;
            }

    }
}