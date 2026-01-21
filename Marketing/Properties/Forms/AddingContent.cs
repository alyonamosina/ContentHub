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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
