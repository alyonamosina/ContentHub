using System.Data;
using TEST.Properties.Сlasses;

namespace Marketing
{
    public partial class AdvancedSearchForm : Form
    {
        private SearchEngine searchEngine;

        public AdvancedSearchForm()
        {
            InitializeComponent();
            searchEngine = new SearchEngine();

            // Устанавливаем обработчики событий
            buttonSearch.Click += buttonSearch_Click;
            buttonReset.Click += buttonReset_Click;

            // Загружаем все данные при открытии формы
            LoadAllData();
        }

        // Метод для загрузки всех данных
        private void LoadAllData()
        {
            try
            {
                // Пустые параметры = загружаем все записи
                DataTable data = searchEngine.SearchContent();
                dataGridView1.DataSource = data;

                // Настраиваем заголовки столбцов (опционально)
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["Title"].HeaderText = "Название";
                    dataGridView1.Columns["Author"].HeaderText = "Автор";
                    dataGridView1.Columns["Description"].HeaderText = "Описание";
                    dataGridView1.Columns["Type"].HeaderText = "Тип";
                    dataGridView1.Columns["Platform"].HeaderText = "Платформа";
                    dataGridView1.Columns["Publication_date"].HeaderText = "Дата публикации";
                    dataGridView1.Columns["Views"].HeaderText = "Просмотры";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }
    private void PerformSearch()
        {
            try
            {
                // Получаем значения из элементов формы
                string title = TitleAdd.Text.Trim();
                string author = AuthorAdd.SelectedItem?.ToString();
                string description = DescriptionAdd.Text.Trim();
                string type = TypeAdd.SelectedItem?.ToString();
                string platform = PlatformAdd.SelectedItem?.ToString();
                string publicationDate = DateTimeAdd.Value.ToString("yyyy-MM-dd");
                string views = VieswsAdd.Text.Trim();

                // Выполняем поиск
                DataTable searchResults = searchEngine.SearchContent(
                    title, author, description, type, platform,
                    publicationDate, views);

                // Отображаем результаты
                dataGridView1.DataSource = searchResults;

                // Обновляем заголовки столбцов
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["Title"].HeaderText = "Название";
                    dataGridView1.Columns["Author"].HeaderText = "Автор";
                    dataGridView1.Columns["Description"].HeaderText = "Описание";
                    dataGridView1.Columns["Type"].HeaderText = "Тип";
                    dataGridView1.Columns["Platform"].HeaderText = "Платформа";
                    dataGridView1.Columns["Publication_date"].HeaderText = "Дата публикации";
                    dataGridView1.Columns["Views"].HeaderText = "Просмотры";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод сброса фильтров
        private void ResetFilters()
        {
            // Очищаем все поля ввода
            TitleAdd.Clear();
            AuthorAdd.SelectedIndex = -1;
            DescriptionAdd.Clear();
            TypeAdd.SelectedIndex = -1;
            PlatformAdd.SelectedIndex = -1;
            DateTimeAdd.Value = DateTime.Now;
            VieswsAdd.Clear();

            // Загружаем все данные
            LoadAllData();
        }
    }
}
