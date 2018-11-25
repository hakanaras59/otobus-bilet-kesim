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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Form2 yeni = new Form2();
        OleDbCommand kmt = new OleDbCommand();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database10.accdb");
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database10DataSet11.kimlik' table. You can move, or remove it, as needed.
            this.kimlikTableAdapter3.Fill(this.database10DataSet11.kimlik);
            // TODO: This line of code loads data into the 'database10DataSet6.kimlik' table. You can move, or remove it, as needed.
       
            // TODO: This line of code loads data into the 'database10DataSet3.kimlik' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'database10DataSet.kimlik' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'database9DataSet.kimlik' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'seferDataSet.sefer' table. You can move, or remove it, as needed.
            
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kimlik", baglan);

            DataSet ds = new DataSet();
            ds.Clear();
            adaptor.Fill(ds, "kimlik");
            dataGridView1.DataSource = ds.Tables["kimlik"];
            adaptor.Dispose();
            
            

        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Koltuklar.accdb");
        OleDbConnection bag = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=satilankoltuk.accdb");
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();
                kmt.Connection = baglan;
                kmt.CommandText = "DELETE FROM kimlik where id=" + label1.Text + "";
                kmt.ExecuteNonQuery();

                baglan.Close();
                OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kimlik", yeni.baglan);

                DataSet ds = new DataSet();
                ds.Clear();
                adaptor.Fill(ds, "kimlik");
                dataGridView1.DataSource = ds.Tables["kimlik"];
                adaptor.Dispose();
                conn.Open();
                OleDbCommand sil = new OleDbCommand("Delete from koltuklar where seferno='" + label1.Text + "'", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                bag.Open();
                OleDbCommand dele = new OleDbCommand("Delete from satilankoltuk where öteki_id='" + label1.Text + "'", bag);
                dele.ExecuteNonQuery();
                bag.Close();
                MessageBox.Show("Seçtiğiniz Sefer Silindi");
            }
            catch
            {
                MessageBox.Show("Tekrar tıklayınız");
            }

            
            
           
         
        }
        OleDbConnection das = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database10.accdb");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baglan.Open();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kimlik", baglan);

            DataTable ds = new DataTable();
            adaptor.Fill(ds);

            label1.Text = ds.Rows[e.RowIndex][7].ToString();
            baglan.Close();
            
        }
        OleDbConnection sari = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database10.accdb");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sari.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from kimlik Where Nereden = '" + comboBox1.Text + "'", baglan);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            sari.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            das.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from kimlik Where Nereye = '" + comboBox2.Text + "'", baglan);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            das.Close();
        }
        Form1 yenifrm = new Form1();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            yenifrm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
