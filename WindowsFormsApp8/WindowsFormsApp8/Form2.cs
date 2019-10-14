using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "knigiZhanarDataSet1.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.knigiZhanarDataSet1.Books);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {

                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\s18009011\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\knigiZhanar.accdb";
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = "";
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
