using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void списокКнигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); 
            if (f.ShowDialog() == DialogResult.OK) ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double text1 = System.Convert.ToDouble(textBox1.Text);
                if (text1 <= 0)
                {
                    MessageBox.Show("Введите число больше нуля");

                };
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double sum; // сумма
            sum = System.Convert.ToDouble(textBox1.Text);
            sum = sum * 388.0;
            label5.Text = System.Convert.ToString(sum) + " тенге  ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double sum; // сумма
            sum = System.Convert.ToDouble(textBox1.Text);
            sum = sum * 9429.0;
            label6.Text = System.Convert.ToString(sum) + " сум  ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "knigiZhanarDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.knigiZhanarDataSet.Books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedValue);
                label4.Text = selected;
            }
            catch (FormatException)
            {
                MessageBox.Show("error");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
