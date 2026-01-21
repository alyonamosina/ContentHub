namespace Marketing
{
    partial class HomeScreen
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
            pictureBox1 = new PictureBox();
            button_advanced_search = new Button();
            dataGridView1 = new DataGridView();
            button_search = new Button();
            searchHomeScreen = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_4;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_advanced_search
            // 
            button_advanced_search.BackColor = Color.OrangeRed;
            button_advanced_search.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_advanced_search.ForeColor = Color.White;
            button_advanced_search.Location = new Point(1002, 12);
            button_advanced_search.Name = "button_advanced_search";
            button_advanced_search.Size = new Size(227, 49);
            button_advanced_search.TabIndex = 1;
            button_advanced_search.Text = "Расширенный поиск";
            button_advanced_search.UseVisualStyleBackColor = false;
            button_advanced_search.Click += button_advanced_search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(228, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1001, 616);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button_search
            // 
            button_search.BackColor = Color.OrangeRed;
            button_search.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(880, 12);
            button_search.Name = "button_search";
            button_search.Size = new Size(116, 49);
            button_search.TabIndex = 3;
            button_search.Text = "Поиск";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // searchHomeScreen
            // 
            searchHomeScreen.BackColor = Color.White;
            searchHomeScreen.Location = new Point(259, 23);
            searchHomeScreen.Name = "searchHomeScreen";
            searchHomeScreen.Size = new Size(598, 27);
            searchHomeScreen.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.search_3748231;
            pictureBox2.Location = new Point(228, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 77);
            button1.Name = "button1";
            button1.Size = new Size(201, 49);
            button1.TabIndex = 6;
            button1.Text = "Добавить контент";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1241, 705);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(searchHomeScreen);
            Controls.Add(button_search);
            Controls.Add(dataGridView1);
            Controls.Add(button_advanced_search);
            Controls.Add(pictureBox1);
            Name = "HomeScreen";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_advanced_search;
        private DataGridView dataGridView1;
        private Button button_search;
        private TextBox searchHomeScreen;
        private PictureBox pictureBox2;
        private Button button1;
    }
}