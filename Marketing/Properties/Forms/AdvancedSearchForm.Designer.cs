namespace Marketing
{
    partial class AdvancedSearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonReset = new Button();
            DateTimeAdd = new DateTimePicker();
            AuthorAdd = new ComboBox();
            buttonSearch = new Button();
            VieswsAdd = new TextBox();
            label7 = new Label();
            label6 = new Label();
            PlatformAdd = new ComboBox();
            label5 = new Label();
            TypeAdd = new ComboBox();
            label4 = new Label();
            DescriptionAdd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TitleAdd = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(12, 471);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(290, 41);
            buttonReset.TabIndex = 33;
            buttonReset.Text = "Сбросить";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // DateTimeAdd
            // 
            DateTimeAdd.Location = new Point(12, 318);
            DateTimeAdd.Name = "DateTimeAdd";
            DateTimeAdd.Size = new Size(290, 27);
            DateTimeAdd.TabIndex = 32;
            // 
            // AuthorAdd
            // 
            AuthorAdd.FormattingEnabled = true;
            AuthorAdd.Items.AddRange(new object[] { "Алена Мосина", "Ольга Киселева", "Настя Зубрилина", "Виталий Малофеев", "Внешний Копирайтер" });
            AuthorAdd.Location = new Point(12, 147);
            AuthorAdd.Name = "AuthorAdd";
            AuthorAdd.Size = new Size(290, 28);
            AuthorAdd.TabIndex = 31;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(12, 424);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(290, 41);
            buttonSearch.TabIndex = 30;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // VieswsAdd
            // 
            VieswsAdd.Location = new Point(12, 374);
            VieswsAdd.Name = "VieswsAdd";
            VieswsAdd.Size = new Size(290, 27);
            VieswsAdd.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(12, 348);
            label7.Name = "label7";
            label7.Size = new Size(203, 23);
            label7.TabIndex = 28;
            label7.Text = "Количество просмотров";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(12, 292);
            label6.Name = "label6";
            label6.Size = new Size(146, 23);
            label6.TabIndex = 27;
            label6.Text = "Дата публикации";
            // 
            // PlatformAdd
            // 
            PlatformAdd.FormattingEnabled = true;
            PlatformAdd.Items.AddRange(new object[] { "VC.ru", "Соц.сети (тг, вк)", "Telegram-канал", "Вконтакте", "Блог на сайте", "Офлайн", "Сайт" });
            PlatformAdd.Location = new Point(12, 261);
            PlatformAdd.Name = "PlatformAdd";
            PlatformAdd.Size = new Size(290, 28);
            PlatformAdd.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 235);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 25;
            label5.Text = "Платформа";
            // 
            // TypeAdd
            // 
            TypeAdd.FormattingEnabled = true;
            TypeAdd.Items.AddRange(new object[] { "Статья", "Кейс", "Презентация", "Пост", "Исследование" });
            TypeAdd.Location = new Point(12, 204);
            TypeAdd.Name = "TypeAdd";
            TypeAdd.Size = new Size(290, 28);
            TypeAdd.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 178);
            label4.Name = "label4";
            label4.Size = new Size(39, 23);
            label4.TabIndex = 23;
            label4.Text = "Тип";
            // 
            // DescriptionAdd
            // 
            DescriptionAdd.Location = new Point(12, 91);
            DescriptionAdd.Name = "DescriptionAdd";
            DescriptionAdd.Size = new Size(290, 27);
            DescriptionAdd.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 21;
            label3.Text = "Описание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 20;
            label2.Text = "Автор";
            // 
            // TitleAdd
            // 
            TitleAdd.Location = new Point(12, 35);
            TitleAdd.Name = "TitleAdd";
            TitleAdd.Size = new Size(290, 27);
            TitleAdd.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 18;
            label1.Text = "Название";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(348, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(886, 477);
            dataGridView1.TabIndex = 34;
            // 
            // AdvancedSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 543);
            Controls.Add(dataGridView1);
            Controls.Add(buttonReset);
            Controls.Add(DateTimeAdd);
            Controls.Add(AuthorAdd);
            Controls.Add(buttonSearch);
            Controls.Add(VieswsAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PlatformAdd);
            Controls.Add(label5);
            Controls.Add(TypeAdd);
            Controls.Add(label4);
            Controls.Add(DescriptionAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TitleAdd);
            Controls.Add(label1);
            Name = "AdvancedSearchForm";
            Text = "AdvancedSearchForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReset;
        private DateTimePicker DateTimeAdd;
        private ComboBox AuthorAdd;
        private Button buttonSearch;
        private TextBox VieswsAdd;
        private Label label7;
        private Label label6;
        private ComboBox PlatformAdd;
        private Label label5;
        private ComboBox TypeAdd;
        private Label label4;
        private TextBox DescriptionAdd;
        private Label label3;
        private Label label2;
        private TextBox TitleAdd;
        private Label label1;
        private DataGridView dataGridView1;
    }
}