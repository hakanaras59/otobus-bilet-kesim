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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 yenia = new Form1();
        public OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database10.accdb");
        string xn;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbCommand kaydet = new OleDbCommand("insert into kimlik (Seferno,Nereden,Nereye,Tarih,Saat,Otobustipi,Fiyat) values('" + textBox2.Text + "','" + comboBox1.Text + "' , '" + comboBox2.Text + "' , '" + dateTimePicker1.Text + "' , '" + comboBox3.Text + "' , '" + comboBox4.Text + "' , '" + textBox1.Text + "')", baglan);
                baglan.Open();
                kaydet.ExecuteNonQuery();
                OleDbDataAdapter hehe = new OleDbDataAdapter("Select*from kimlik", baglan);
                DataTable tablooo = new DataTable();
                hehe.Fill(tablooo);
                xn = tablooo.Rows[tablooo.Rows.Count - 1][7].ToString();




                baglan.Close();

                MessageBox.Show("Sefer Eklenmiştir");
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Koltuklar.accdb");
                connect.Open();
                OleDbCommand eklee = new OleDbCommand("insert into koltuklar (seferno)values('" + xn + "')", connect);
                eklee.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                MessageBox.Show("Tekrar Deneyiniz");
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            yenia.Show();
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        
    }
}
