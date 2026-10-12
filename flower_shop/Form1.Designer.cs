namespace flower_shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            txtGulNovu = new DataGridViewTextBoxColumn();
            txtSay = new DataGridViewTextBoxColumn();
            txtQiymet = new DataGridViewTextBoxColumn();
            lblToplamGelir = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtGulNovu, txtSay, txtQiymet, lblToplamGelir });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 188);
            dataGridView1.TabIndex = 0;
            // 
            // txtGulNovu
            // 
            txtGulNovu.HeaderText = "Gül növü (gül adı)";
            txtGulNovu.MinimumWidth = 6;
            txtGulNovu.Name = "txtGulNovu";
            // 
            // txtSay
            // 
            txtSay.HeaderText = "Satış sayı";
            txtSay.MinimumWidth = 6;
            txtSay.Name = "txtSay";
            // 
            // txtQiymet
            // 
            txtQiymet.HeaderText = "Qiyməti";
            txtQiymet.MinimumWidth = 6;
            txtQiymet.Name = "txtQiymet";
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.HeaderText = "Yekun qiyməti";
            lblToplamGelir.MinimumWidth = 6;
            lblToplamGelir.Name = "lblToplamGelir";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkSlateBlue;
            groupBox1.Location = new Point(12, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 227);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gül məlumatları";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(281, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(274, 143);
            button1.Name = "button1";
            button1.Size = new Size(123, 65);
            button1.TabIndex = 5;
            button1.Text = "Satış et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(74, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 31);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(156, 149);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 2;
            label3.Text = "Qiymət";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 149);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 1;
            label2.Text = "Say";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Gül növü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(497, 223);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 3;
            label4.Text = "Toplam gəlir:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(626, 223);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 4;
            label5.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(482, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkSlateBlue;
            button2.Location = new Point(700, 383);
            button2.Name = "button2";
            button2.Size = new Size(88, 36);
            button2.TabIndex = 6;
            button2.Text = "Çıxış";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private DataGridViewTextBoxColumn txtGulNovu;
        private DataGridViewTextBoxColumn txtSay;
        private DataGridViewTextBoxColumn txtQiymet;
        private DataGridViewTextBoxColumn lblToplamGelir;
    }
}
