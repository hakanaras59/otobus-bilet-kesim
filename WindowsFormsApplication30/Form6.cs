using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication30
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


       
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database10.accdb");
 Form5 form5 = new Form5();
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database10DataSet5.kimlik' table. You can move, or remove it, as needed.
            this.kimlikTableAdapter2.Fill(this.database10DataSet5.kimlik);
            // TODO: This line of code loads data into the 'database10DataSet4.kimlik' table. You can move, or remove it, as needed.
            this.kimlikTableAdapter1.Fill(this.database10DataSet4.kimlik);
            
         
            baglan.Open();
            DataTable dt = new DataTable();
   
            dt.Clear();
            
            
            OleDbDataAdapter ad = new OleDbDataAdapter("Select * from kimlik Where Nereden = '" + label4.Text + "' and Nereye = '" +label5.Text +"'and Tarih='"+label6.Text+ "'",baglan);   
            
            
            ad.Fill(dt);
           
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Form7 form7 = new Form7();
                form7.label1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                form7.label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                form7.label3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                form7.label4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                form7.label5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                form7.label6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                form7.label7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                form7.label19.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                form7.Show();
            }
            catch
            {
                MessageBox.Show("Sefer seçmediniz");
            }
                

               
           
                
        }

       
    }
}
