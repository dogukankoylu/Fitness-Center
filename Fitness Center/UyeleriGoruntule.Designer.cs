namespace Fitness_Center
{
    partial class UyeleriGoruntule
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            label9 = new Label();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(358, 9);
            label2.Name = "label2";
            label2.Size = new Size(424, 41);
            label2.TabIndex = 24;
            label2.Text = "CRYSTAL FITNESS CENTER";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.GridColor = Color.DarkOrange;
            dataGridView1.Location = new Point(122, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(880, 434);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 98);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 34);
            textBox1.TabIndex = 31;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaShell;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(670, 96);
            button2.Name = "button2";
            button2.Size = new Size(123, 36);
            button2.TabIndex = 32;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(537, 96);
            button1.Name = "button1";
            button1.Size = new Size(123, 36);
            button1.TabIndex = 33;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaShell;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.DarkOrange;
            button4.Location = new Point(453, 576);
            button4.Name = "button4";
            button4.Size = new Size(184, 36);
            button4.TabIndex = 34;
            button4.Text = "Login Ekranı";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.ForeColor = Color.DarkOrange;
            label9.Location = new Point(475, 50);
            label9.Name = "label9";
            label9.Size = new Size(162, 32);
            label9.TabIndex = 35;
            label9.Text = "Üyeleri Listele";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(1091, 10);
            label1.Name = "label1";
            label1.Size = new Size(36, 40);
            label1.TabIndex = 35;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaShell;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.DarkOrange;
            button3.Location = new Point(799, 96);
            button3.Name = "button3";
            button3.Size = new Size(123, 36);
            button3.TabIndex = 32;
            button3.Text = "Ana Sayfa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UyeleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1139, 616);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UyeleriGoruntule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeleriGoruntule";
            Load += UyeleriGoruntule_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button button4;
        private Label label9;
        private Label label1;
        private Button button3;
    }
}