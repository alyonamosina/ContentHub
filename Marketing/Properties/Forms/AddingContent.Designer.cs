namespace Marketing
{
    partial class AddingContent
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
            label1 = new Label();
            TitleAdd = new TextBox();
            label2 = new Label();
            DescriptionAdd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TypeAdd = new ComboBox();
            PlatformAdd = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            VieswsAdd = new TextBox();
            label7 = new Label();
            buttonAdd = new Button();
            AuthorAdd = new ComboBox();
            DateTimeAdd = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // TitleAdd
            // 
            TitleAdd.Location = new Point(26, 57);
            TitleAdd.Multiline = true;
            TitleAdd.Name = "TitleAdd";
            TitleAdd.Size = new Size(758, 34);
            TitleAdd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(26, 193);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 2;
            label2.Text = "Автор";
            // 
            // DescriptionAdd
            // 
            DescriptionAdd.Location = new Point(26, 140);
            DescriptionAdd.Multiline = true;
            DescriptionAdd.Name = "DescriptionAdd";
            DescriptionAdd.Size = new Size(758, 34);
            DescriptionAdd.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(26, 109);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 4;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(26, 270);
            label4.Name = "label4";
            label4.Size = new Size(46, 28);
            label4.TabIndex = 6;
            label4.Text = "Тип";
            // 
            // TypeAdd
            // 
            TypeAdd.FormattingEnabled = true;
            TypeAdd.Items.AddRange(new object[] { "Статья", "Кейс", "Презентация", "Пост", "Исследование" });
            TypeAdd.Location = new Point(26, 301);
            TypeAdd.Name = "TypeAdd";
            TypeAdd.Size = new Size(273, 28);
            TypeAdd.TabIndex = 7;
            // 
            // PlatformAdd
            // 
            PlatformAdd.FormattingEnabled = true;
            PlatformAdd.Items.AddRange(new object[] { "VC.ru", "Соц.сети (тг, вк)", "Telegram-канал", "Вконтакте", "Блог на сайте", "Офлайн", "Сайт" });
            PlatformAdd.Location = new Point(26, 378);
            PlatformAdd.Name = "PlatformAdd";
            PlatformAdd.Size = new Size(273, 28);
            PlatformAdd.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(26, 347);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 8;
            label5.Text = "Платформа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(340, 193);
            label6.Name = "label6";
            label6.Size = new Size(172, 28);
            label6.TabIndex = 10;
            label6.Text = "Дата публикации";
            // 
            // VieswsAdd
            // 
            VieswsAdd.Location = new Point(340, 301);
            VieswsAdd.Name = "VieswsAdd";
            VieswsAdd.Size = new Size(290, 27);
            VieswsAdd.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(340, 270);
            label7.Name = "label7";
            label7.Size = new Size(239, 28);
            label7.TabIndex = 12;
            label7.Text = "Количество просмотров";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(26, 453);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(273, 49);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Добавить файл";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AuthorAdd
            // 
            AuthorAdd.FormattingEnabled = true;
            AuthorAdd.Items.AddRange(new object[] { "Алена Мосина", "Ольга Киселева", "Настя Зубрилина", "Виталий Малофеев", "Внешний Копирайтер" });
            AuthorAdd.Location = new Point(26, 223);
            AuthorAdd.Name = "AuthorAdd";
            AuthorAdd.Size = new Size(273, 28);
            AuthorAdd.TabIndex = 15;
            // 
            // DateTimeAdd
            // 
            DateTimeAdd.Location = new Point(340, 224);
            DateTimeAdd.Name = "DateTimeAdd";
            DateTimeAdd.Size = new Size(290, 27);
            DateTimeAdd.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(26, 522);
            button1.Name = "button1";
            button1.Size = new Size(273, 49);
            button1.TabIndex = 17;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddingContent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 739);
            Controls.Add(button1);
            Controls.Add(DateTimeAdd);
            Controls.Add(AuthorAdd);
            Controls.Add(buttonAdd);
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
            Name = "AddingContent";
            Text = "AddingContent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TitleAdd;
        private Label label2;
        private TextBox DescriptionAdd;
        private Label label3;
        private Label label4;
        private ComboBox TypeAdd;
        private ComboBox PlatformAdd;
        private Label label5;
        private Label label6;
        private TextBox VieswsAdd;
        private Label label7;
        private Button buttonAdd;
        private ComboBox AuthorAdd;
        private DateTimePicker DateTimeAdd;
        private Button button1;
    }
}