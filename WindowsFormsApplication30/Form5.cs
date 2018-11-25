using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace WindowsFormsApplication30
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        public ArrayList dizi = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
           Form6 yeni6 = new Form6();


           
           
            yeni6.label4.Text = comboBox1.Text;
            yeni6.label5.Text = comboBox2.Text;
            yeni6.label6.Text = dateTimePicker1.Text;
            
             yeni6.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
          

        }

    }
}
