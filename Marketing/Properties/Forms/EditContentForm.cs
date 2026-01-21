using System.Data;
using TEST.Properties.Сlasses;

namespace Marketing
{
    public partial class EditContentForm : Form
    {
        private int contentId;
        private ContentReader reader = new ContentReader();

        public EditContentForm(int id)
        {
            InitializeComponent();
            contentId = id;
            LoadContentData();
        }

        private void LoadContentData()
        {
            // Получаем данные записи по ID
            DataRow row = reader.GetContentById(contentId);

            if (row != null)
            {
                // Заполняем поля данными из БД
                TitleAdd.Text = row["Title"].ToString();
                AuthorAdd.Text = row["Author"].ToString();
                DescriptionAdd.Text = row["Description"].ToString();
                TypeAdd.Text = row["Type"].ToString();
                PlatformAdd.Text = row["Platform"].ToString();
                DateTimeAdd.Value = Convert.ToDateTime(row["Publication_date"]);
                VieswsAdd.Text = row["Views"].ToString();
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            ContentUpdater updater = new ContentUpdater();

            updater.Update(
                contentId,
                TitleAdd.Text,
                AuthorAdd.Text,
                DescriptionAdd.Text,
                TypeAdd.Text,
                PlatformAdd.Text,
                DateTimeAdd.Value,
                int.Parse(VieswsAdd.Text)
            );

            MessageBox.Show("Изменения сохранены");
            this.Close();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Удалить запись?", "Подтверждение",
                                                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ContentDeleter deleter = new ContentDeleter();
                    deleter.Delete(contentId);
                    this.Close();
                }
            }
        }

    }
}
