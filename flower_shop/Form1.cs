using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace flower_shop
{
    public partial class Form1 : Form
    {
        private double toplamGelir = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("colGul", "Gül növü (gül adı)");
                dataGridView1.Columns.Add("colSay", "Satış sayı");
                dataGridView1.Columns.Add("colQiymet", "Qiyməti");
                dataGridView1.Columns.Add("colYekun", "Yekun qiyməti");
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label5.Text = "0.00";

            TumButonlariBagla(this);
        }

        private void TumButonlariBagla(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn && (btn.Name == "button2" || btn.Text.Trim().ToLower().Contains("çıxış") || btn.Text.Trim().ToLower().Contains("cixis")))
                {
                    btn.Click -= button2_Click;
                    btn.Click += button2_Click;
                }

                if (c.HasChildren)
                {
                    TumButonlariBagla(c);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Zəhmət olmasa, bütün xanaları doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text.Trim(), out int count) || count <= 0)
            {
                MessageBox.Show("Satış sayı müsbət tam ədəd olmalıdır (0 və mənfi ola bilməz)!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string qiymetInput = textBox3.Text.Trim().Replace('.', ',');
            if (!double.TryParse(qiymetInput, NumberStyles.Any, new CultureInfo("tr-TR"), out double price) || price <= 0)
            {
                MessageBox.Show("Qiymət müsbət ədəd olmalıdır (0 və mənfi ola bilməz)!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = count * price;

            dataGridView1.Rows.Add(
                textBox1.Text.Trim(),
                count.ToString(),
                price.ToString("F2"),
                result.ToString("F2")
            );

            toplamGelir += result;
            label5.Text = toplamGelir.ToString("F2");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show(
                "Çıxış edilsinmi?",
                "Çıxış Təsdiqi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            if (box == null) return;

            int galinliq = 2;
            Color reng = Color.White;

            using (Pen pen = new Pen(reng, galinliq))
            {
                Size textSize = TextRenderer.MeasureText(box.Text, box.Font);
                Rectangle rect = box.ClientRectangle;

                rect.Y += textSize.Height / 2;
                rect.Height -= textSize.Height / 2;

                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}