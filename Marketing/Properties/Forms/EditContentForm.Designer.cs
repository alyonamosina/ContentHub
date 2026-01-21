namespace Marketing
{
    partial class EditContentForm
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
            buttonDelete = new Button();
            DateTimeAdd = new DateTimePicker();
            AuthorAdd = new ComboBox();
            buttonSave = new Button();
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
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(24, 519);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(273, 49);
            buttonDelete.TabIndex = 33;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // DateTimeAdd
            // 
            DateTimeAdd.Location = new Point(338, 221);
            DateTimeAdd.Name = "DateTimeAdd";
            DateTimeAdd.Size = new Size(290, 27);
            DateTimeAdd.TabIndex = 32;
            // 
            // AuthorAdd
            // 
            AuthorAdd.FormattingEnabled = true;
            AuthorAdd.Items.AddRange(new object[] { "Алена Мосина", "Ольга Киселева", "Настя Зубрилина", "Виталий Малофеев", "Внешний Копирайтер" });
            AuthorAdd.Location = new Point(24, 220);
            AuthorAdd.Name = "AuthorAdd";
            AuthorAdd.Size = new Size(273, 28);
            AuthorAdd.TabIndex = 31;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(24, 450);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(273, 49);
            buttonSave.TabIndex = 30;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // VieswsAdd
            // 
            VieswsAdd.Location = new Point(338, 298);
            VieswsAdd.Name = "VieswsAdd";
            VieswsAdd.Size = new Size(290, 27);
            VieswsAdd.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(338, 267);
            label7.Name = "label7";
            label7.Size = new Size(239, 28);
            label7.TabIndex = 28;
            label7.Text = "Количество просмотров";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(338, 190);
            label6.Name = "label6";
            label6.Size = new Size(172, 28);
            label6.TabIndex = 27;
            label6.Text = "Дата публикации";
            // 
            // PlatformAdd
            // 
            PlatformAdd.FormattingEnabled = true;
            PlatformAdd.Items.AddRange(new object[] { "VC.ru", "Соц.сети (тг, вк)", "Telegram-канал", "Вконтакте", "Блог на сайте", "Офлайн", "Сайт" });
            PlatformAdd.Location = new Point(24, 375);
            PlatformAdd.Name = "PlatformAdd";
            PlatformAdd.Size = new Size(273, 28);
            PlatformAdd.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 344);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 25;
            label5.Text = "Платформа";
            // 
            // TypeAdd
            // 
            TypeAdd.FormattingEnabled = true;
            TypeAdd.Items.AddRange(new object[] { "Статья", "Кейс", "Презентация", "Пост", "Исследование" });
            TypeAdd.Location = new Point(24, 298);
            TypeAdd.Name = "TypeAdd";
            TypeAdd.Size = new Size(273, 28);
            TypeAdd.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 267);
            label4.Name = "label4";
            label4.Size = new Size(46, 28);
            label4.TabIndex = 23;
            label4.Text = "Тип";
            // 
            // DescriptionAdd
            // 
            DescriptionAdd.Location = new Point(24, 137);
            DescriptionAdd.Multiline = true;
            DescriptionAdd.Name = "DescriptionAdd";
            DescriptionAdd.Size = new Size(758, 34);
            DescriptionAdd.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 106);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 21;
            label3.Text = "Описание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 190);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 20;
            label2.Text = "Автор";
            // 
            // TitleAdd
            // 
            TitleAdd.Location = new Point(24, 54);
            TitleAdd.Multiline = true;
            TitleAdd.Name = "TitleAdd";
            TitleAdd.Size = new Size(758, 34);
            TitleAdd.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 18;
            label1.Text = "Название";
            // 
            // EditContentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 615);
            Controls.Add(buttonDelete);
            Controls.Add(DateTimeAdd);
            Controls.Add(AuthorAdd);
            Controls.Add(buttonSave);
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
            Name = "EditContentForm";
            Text = "EditContentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDelete;
        private DateTimePicker DateTimeAdd;
        private ComboBox AuthorAdd;
        private Button buttonSave;
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
    }
}