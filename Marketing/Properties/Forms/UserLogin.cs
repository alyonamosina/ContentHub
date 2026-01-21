using Microsoft.Data.SqlClient;
using System.Configuration;
using TEST.Properties.Сlasses;

namespace Marketing
{
    public partial class UserLogin : Form
    {
        private SqlConnection sqlConnection = null;
        private AuthenticationService authService;

        public UserLogin()
        {
            InitializeComponent();

            authService = new AuthenticationService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString);
            
            sqlConnection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [UserLogin] (Username, Password) VALUES (@Username, @Password)", sqlConnection);

            command.Parameters.AddWithValue("Username", textBox_Name.Text);
            command.Parameters.AddWithValue("Password", textBox_Password.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Берем данные из полей ввода
            string username = textBox_Name.Text;
            string password = textBox_Password.Text;

            // Проверяем через наш класс AuthenticationService
            bool isValid = authService.ValidateUser(username, password);

            // Действуем по результату
            if (isValid)
            {
                // Открываем Form2
                HomeScreen mainForm = new HomeScreen();
                mainForm.Show();
                this.Hide(); // Скрываем окно входа
            }
            else
            {
                // Показываем ошибку
                MessageBox.Show("Неверно введены данные", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}