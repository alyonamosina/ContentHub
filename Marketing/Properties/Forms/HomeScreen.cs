using System.Data;
using System.Configuration;
using TEST.Properties.Сlasses;

namespace Marketing
{
    public partial class HomeScreen : Form
    {
        private string connectionString; // Добавляем переменную для хранения строки подключения
        private Label lblResultCount;

        public HomeScreen()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Application.Exit();

            // Получаем строку подключения из конфигурации
            connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
            LoadData(); // Запуск вывода всей таблицы
        }

        private void LoadData()
        {
            DataTable dt = DatabaseHelper.LoadAllContent();
            dataGridView1.DataSource = dt;
        }

        

        private void button1_Click(object sender, EventArgs e) // Добавление новой записи
        {
            AddingContent mainForm = new AddingContent();
            mainForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Получаем ID из выбранной строки
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                // Открываем форму редактирования с ID
                EditContentForm editForm = new EditContentForm(id);
                editForm.ShowDialog();

                // Обновляем таблицу после закрытия формы редактирования
                LoadData(); // твой метод загрузки данных в DataGridView
            }
        }
    }
}