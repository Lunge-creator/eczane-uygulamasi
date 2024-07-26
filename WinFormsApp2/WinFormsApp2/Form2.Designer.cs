namespace WinFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            textBoxBark = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label7 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBoxSt = new TextBox();
            textBoxFiyat = new TextBox();
            textBoxtur = new TextBox();
            textBoxad = new TextBox();
            panel2 = new Panel();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            textBoxStok = new TextBox();
            label1 = new Label();
            textBoxBarkod = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxBark);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxSt);
            panel1.Controls.Add(textBoxFiyat);
            panel1.Controls.Add(textBoxtur);
            panel1.Controls.Add(textBoxad);
            panel1.Location = new Point(12, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 430);
            panel1.TabIndex = 0;
            // 
            // textBoxBark
            // 
            textBoxBark.Location = new Point(104, 140);
            textBoxBark.Name = "textBoxBark";
            textBoxBark.Size = new Size(125, 27);
            textBoxBark.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(18, 147);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 16;
            label8.Text = "Barkod";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(622, 140);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(528, 46);
            button4.Name = "button4";
            button4.Size = new Size(94, 51);
            button4.TabIndex = 14;
            button4.Text = "Görüntüle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(390, 46);
            button3.Name = "button3";
            button3.Size = new Size(102, 51);
            button3.TabIndex = 13;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(252, 46);
            button2.Name = "button2";
            button2.Size = new Size(99, 51);
            button2.TabIndex = 12;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(18, 215);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 11;
            label7.Text = "Kayıt Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(18, 182);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 10;
            label6.Text = "Gerçelilik Süresi";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(158, 210);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(18, 110);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 9;
            label5.Text = "Stok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(18, 77);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 8;
            label4.Text = "Fiyat";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 177);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(18, 44);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 7;
            label3.Text = "Ürün Türü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(18, 11);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Ürün Adı";
            // 
            // textBoxSt
            // 
            textBoxSt.Location = new Point(104, 107);
            textBoxSt.Name = "textBoxSt";
            textBoxSt.Size = new Size(125, 27);
            textBoxSt.TabIndex = 3;
            // 
            // textBoxFiyat
            // 
            textBoxFiyat.Location = new Point(104, 74);
            textBoxFiyat.Name = "textBoxFiyat";
            textBoxFiyat.Size = new Size(125, 27);
            textBoxFiyat.TabIndex = 2;
            // 
            // textBoxtur
            // 
            textBoxtur.Location = new Point(104, 41);
            textBoxtur.Name = "textBoxtur";
            textBoxtur.Size = new Size(125, 27);
            textBoxtur.TabIndex = 1;
            // 
            // textBoxad
            // 
            textBoxad.Location = new Point(104, 7);
            textBoxad.Name = "textBoxad";
            textBoxad.Size = new Size(125, 27);
            textBoxad.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-3, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 155);
            panel2.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Imprint MT Shadow", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(543, 50);
            label9.Name = "label9";
            label9.Size = new Size(454, 47);
            label9.TabIndex = 1;
            label9.Text = "Ecza Depo Otamasyonu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBoxStok);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBoxBarkod);
            panel3.Location = new Point(646, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 430);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(245, 68);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxStok
            // 
            textBoxStok.Location = new Point(20, 154);
            textBoxStok.Multiline = true;
            textBoxStok.Name = "textBoxStok";
            textBoxStok.Size = new Size(319, 217);
            textBoxStok.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(20, 73);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Barkod";
            // 
            // textBoxBarkod
            // 
            textBoxBarkod.Location = new Point(85, 70);
            textBoxBarkod.Name = "textBoxBarkod";
            textBoxBarkod.Size = new Size(144, 27);
            textBoxBarkod.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 601);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBoxStok;
        private Label label1;
        private TextBox textBoxBarkod;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private TextBox textBoxSt;
        private TextBox textBoxFiyat;
        private TextBox textBoxtur;
        private TextBox textBoxad;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label6;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox textBoxBark;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
    }
}