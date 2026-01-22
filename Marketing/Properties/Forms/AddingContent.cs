using Marketing.Properties.Сlasses;

namespace Marketing
{
    public partial class AddingContent : Form
    {
        public AddingContent()
        {
            InitializeComponent();
            this.FormClosing += AddingContent_FormClosing;
        }

        private void AddingContent_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Открываем HomeScreen при закрытии формы (включая крестик)
            HomeScreen home = new HomeScreen();
            home.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            var validator = new ContentFormValidator();

            bool isValid = validator.Validate(
                TitleAdd.Text,
                DescriptionAdd.Text,
                VieswsAdd.Text,

                AuthorAdd.Text,
                AuthorAdd.SelectedItem != null,

                TypeAdd.Text,
                TypeAdd.SelectedItem != null,

                PlatformAdd.Text,
                PlatformAdd.SelectedItem != null
            );

            if (!isValid)
            {
                MessageBox.Show(
                    "Чтобы добавить контент, заполните все поля",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }


            ContentAdder adder = new ContentAdder();

            adder.Add(
            TitleAdd.Text,
            AuthorAdd.SelectedItem?.ToString() ?? AuthorAdd.Text,
            DescriptionAdd.Text,
            TypeAdd.SelectedItem?.ToString() ?? TypeAdd.Text,
            PlatformAdd.SelectedItem?.ToString() ?? PlatformAdd.Text,
            DateTimeAdd.Value,
            int.Parse(VieswsAdd.Text)
            );

            MessageBox.Show("Добавлено");

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
