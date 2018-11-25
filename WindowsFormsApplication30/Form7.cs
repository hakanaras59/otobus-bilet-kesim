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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
       
        private void Form7_Load(object sender, EventArgs e)
        {

            if (label6.Text == "TRAVEGO 46" || label6.Text == "SETRA 46" || label6.Text == "MAN FORTUNA" || label6.Text == "NEOPLAN CİTYLİNER")
            {
                button47.Visible = false;
                button48.Visible = false;
                button49.Visible = false;
                button50.Visible = false;
                groupBox1.Size = new Size(198, 497);
            }
            if (label6.Text == "TRAVEGO 2+1")
            {
                button2.Visible = false;
                button6.Visible = false;
                button10.Visible = false;
                button14.Visible = false;
                button18.Visible = false;
                button22.Visible = false;
                button26.Visible = false;
                button28.Visible = false;
                button32.Visible = false;
                button36.Visible = false;
                button40.Visible = false;
                button44.Visible = false;
                button48.Visible = false;
            }


            radioButton1.Checked = true;
            label19.Visible = false;
            dataGridView1.Visible = false;
            // TODO: This line of code loads data into the 'koltuklarDataSet2.koltuklar' table. You can move, or remove it, as needed.
            this.koltuklarTableAdapter.Fill(this.koltuklarDataSet2.koltuklar);
            göster();
            baglanti.Open();
            OleDbDataAdapter kltuklar = new OleDbDataAdapter("Select*from koltuklar where seferno='" + label19.Text + "'", baglanti);
            DataTable kltuktablo = new DataTable();
            kltuklar.Fill(kltuktablo);

            if (kltuktablo.Rows[0][1].ToString() == "1")
            {
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][2].ToString() == "1")
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][3].ToString() == "1")
            {
                button3.BackColor = Color.Red;
            }
            else
            {
                button3.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][4].ToString() == "1")
            {
                button4.BackColor = Color.Red;
            }
            else
            {
                button4.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][5].ToString() == "1")
            {
                button5.BackColor = Color.Red;
            }
            else
            {
                button5.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][6].ToString() == "1")
            {
                button6.BackColor = Color.Red;
            }
            else
            {
                button6.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][7].ToString() == "1")
            {
                button7.BackColor = Color.Red;
            }
            else
            {
                button7.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][8].ToString() == "1")
            {
                button8.BackColor = Color.Red;
            }
            else
            {
                button8.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][9].ToString() == "1")
            {
                button9.BackColor = Color.Red;
            }
            else
            {
                button9.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][10].ToString() == "1")
            {
                button10.BackColor = Color.Red;
            }
            else
            {
                button10.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][11].ToString() == "1")
            {
                button11.BackColor = Color.Red;
            }
            else
            {
                button11.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][12].ToString() == "1")
            {
                button12.BackColor = Color.Red;
            }
            else
            {
                button12.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][13].ToString() == "1")
            {
                button13.BackColor = Color.Red;
            }
            else
            {
                button13.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][14].ToString() == "1")
            {
                button14.BackColor = Color.Red;
            }
            else
            {
                button14.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][15].ToString() == "1")
            {
                button15.BackColor = Color.Red;
            }
            else
            {
                button15.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][16].ToString() == "1")
            {
                button16.BackColor = Color.Red;
            }
            else
            {
                button16.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][17].ToString() == "1")
            {
                button17.BackColor = Color.Red;
            }
            else
            {
                button17.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][18].ToString() == "1")
            {
                button18.BackColor = Color.Red;
            }
            else
            {
                button18.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][19].ToString() == "1")
            {
                button19.BackColor = Color.Red;
            }
            else
            {
                button19.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][20].ToString() == "1")
            {
                button20.BackColor = Color.Red;
            }
            else
            {
                button20.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][21].ToString() == "1")
            {
                button21.BackColor = Color.Red;
            }
            else
            {
                button21.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][22].ToString() == "1")
            {
                button22.BackColor = Color.Red;
            }
            else
            {
                button22.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][23].ToString() == "1")
            {
                button23.BackColor = Color.Red;
            }
            else
            {
                button23.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][24].ToString() == "1")
            {
                button24.BackColor = Color.Red;
            }
            else
            {
                button24.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][25].ToString() == "1")
            {
                button25.BackColor = Color.Red;
            }
            else
            {
                button25.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][26].ToString() == "1")
            {
                button26.BackColor = Color.Red;
            }
            else
            {
                button26.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][27].ToString() == "1")
            {
                button27.BackColor = Color.Red;
            }
            else
            {
                button27.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][28].ToString() == "1")
            {
                button28.BackColor = Color.Red;
            }
            else
            {
                button28.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][29].ToString() == "1")
            {
                button29.BackColor = Color.Red;
            }
            else
            {
                button29.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][30].ToString() == "1")
            {
                button30.BackColor = Color.Red;
            }
            else
            {
                button30.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][31].ToString() == "1")
            {
                button31.BackColor = Color.Red;
            }
            else
            {
                button31.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][32].ToString() == "1")
            {
                button32.BackColor = Color.Red;
            }
            else
            {
                button32.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][33].ToString() == "1")
            {
                button33.BackColor = Color.Red;
            }
            else
            {
                button33.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][34].ToString() == "1")
            {
                button34.BackColor = Color.Red;
            }
            else
            {
                button34.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][35].ToString() == "1")
            {
                button35.BackColor = Color.Red;
            }
            else
            {
                button35.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][36].ToString() == "1")
            {
                button36.BackColor = Color.Red;
            }
            else
            {
                button36.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][37].ToString() == "1")
            {
                button37.BackColor = Color.Red;
            }
            else
            {
                button37.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][38].ToString() == "1")
            {
                button38.BackColor = Color.Red;
            }
            else
            {
                button38.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][39].ToString() == "1")
            {
                button39.BackColor = Color.Red;
            }
            else
            {
                button39.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][40].ToString() == "1")
            {
                button40.BackColor = Color.Red;
            }
            else
            {
                button40.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][41].ToString() == "1")
            {
                button41.BackColor = Color.Red;
            }
            else
            {
                button41.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][42].ToString() == "1")
            {
                button42.BackColor = Color.Red;
            }
            else
            {
                button42.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][43].ToString() == "1")
            {
                button43.BackColor = Color.Red;
            }
            else
            {
                button43.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][44].ToString() == "1")
            {
                button44.BackColor = Color.Red;
            }
            else
            {
                button44.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][45].ToString() == "1")
            {
                button45.BackColor = Color.Red;
            }
            else
            {
                button45.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][46].ToString() == "1")
            {
                button46.BackColor = Color.Red;
            }
            else
            {
                button46.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][47].ToString() == "1")
            {
                button47.BackColor = Color.Red;
            }
            else
            {
                button47.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][48].ToString() == "1")
            {
                button48.BackColor = Color.Red;
            }
            else
            {
                button48.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][49].ToString() == "1")
            {
                button49.BackColor = Color.Red;
            }
            else
            {
                button49.BackColor = Color.White;
            }
            if (kltuktablo.Rows[0][50].ToString() == "1")
            {
                button50.BackColor = Color.Red;
            }
            else
            {
                button50.BackColor = Color.White;
            }

            baglanti.Close();



            if (button1.BackColor == Color.Red)
            {
                button1.Enabled = false;
            }
            if (button2.BackColor == Color.Red)
            {
                button2.Enabled = false;
            }
            if (button3.BackColor == Color.Red)
            {
                button3.Enabled = false;
            }
            if (button4.BackColor == Color.Red)
            {
                button4.Enabled = false;
            }
            if (button5.BackColor == Color.Red)
            {
                button5.Enabled = false;
            }
            if (button6.BackColor == Color.Red)
            {
                button6.Enabled = false;
            }
            if (button7.BackColor == Color.Red)
            {
                button7.Enabled = false;
            }
            if (button8.BackColor == Color.Red)
            {
                button8.Enabled = false;
            }
            if (button9.BackColor == Color.Red)
            {
                button9.Enabled = false;
            }
            if (button10.BackColor == Color.Red)
            {
                button10.Enabled = false;
            }
            if (button11.BackColor == Color.Red)
            {
                button11.Enabled = false;
            }
            if (button12.BackColor == Color.Red)
            {
                button12.Enabled = false;
            }
            if (button13.BackColor == Color.Red)
            {
                button13.Enabled = false;
            }
            if (button14.BackColor == Color.Red)
            {
                button14.Enabled = false;
            }
            if (button15.BackColor == Color.Red)
            {
                button15.Enabled = false;
            }
            if (button16.BackColor == Color.Red)
            {
                button16.Enabled = false;
            }
            if (button17.BackColor == Color.Red)
            {
                button17.Enabled = false;
            }
            if (button18.BackColor == Color.Red)
            {
                button18.Enabled = false;
            }
            if (button19.BackColor == Color.Red)
            {
                button19.Enabled = false;
            }
            if (button18.BackColor == Color.Red)
            {
                button18.Enabled = false;
            }
            if (button19.BackColor == Color.Red)
            {
                button19.Enabled = false;
            }
            if (button20.BackColor == Color.Red)
            {
                button20.Enabled = false;
            }
            if (button21.BackColor == Color.Red)
            {
                button21.Enabled = false;
            }
            if (button22.BackColor == Color.Red)
            {
                button22.Enabled = false;
            }
            if (button23.BackColor == Color.Red)
            {
                button23.Enabled = false;
            }
            if (button24.BackColor == Color.Red)
            {
                button24.Enabled = false;
            }
            if (button25.BackColor == Color.Red)
            {
                button25.Enabled = false;
            }
            if (button26.BackColor == Color.Red)
            {
                button26.Enabled = false;
            }
            if (button27.BackColor == Color.Red)
            {
                button27.Enabled = false;
            }
            if (button28.BackColor == Color.Red)
            {
                button28.Enabled = false;
            }
            if (button29.BackColor == Color.Red)
            {
                button29.Enabled = false;
            }
            if (button30.BackColor == Color.Red)
            {
                button30.Enabled = false;
            }
            if (button31.BackColor == Color.Red)
            {
                button31.Enabled = false;
            }
            if (button32.BackColor == Color.Red)
            {
                button32.Enabled = false;
            }
            if (button33.BackColor == Color.Red)
            {
                button33.Enabled = false;
            }
            if (button34.BackColor == Color.Red)
            {
                button34.Enabled = false;
            }
            if (button35.BackColor == Color.Red)
            {
                button35.Enabled = false;
            }
            if (button36.BackColor == Color.Red)
            {
                button36.Enabled = false;
            }
            if (button37.BackColor == Color.Red)
            {
                button37.Enabled = false;
            }
            if (button38.BackColor == Color.Red)
            {
                button38.Enabled = false;
            }
            if (button39.BackColor == Color.Red)
            {
                button39.Enabled = false;
            }
            if (button40.BackColor == Color.Red)
            {
                button40.Enabled = false;
            }
            if (button41.BackColor == Color.Red)
            {
                button41.Enabled = false;
            }
            if (button42.BackColor == Color.Red)
            {
                button42.Enabled = false;
            }
            if (button43.BackColor == Color.Red)
            {
                button43.Enabled = false;
            }
            if (button44.BackColor == Color.Red)
            {
                button44.Enabled = false;
            }
            if (button45.BackColor == Color.Red)
            {
                button45.Enabled = false;
            }
            if (button46.BackColor == Color.Red)
            {
                button46.Enabled = false;
            }
            if (button47.BackColor == Color.Red)
            {
                button47.Enabled = false;
            }
            if (button48.BackColor == Color.Red)
            {
                button48.Enabled = false;
            }
            if (button49.BackColor == Color.Red)
            {
                button49.Enabled = false;
            }
            if (button50.BackColor == Color.Red)
            {
                button50.Enabled = false;
            }
            conn.Open();
            OleDbDataAdapter koltukrenkmavi = new OleDbDataAdapter("Select * from satilankoltuk where id='" + label19.Text + "'", conn);
            DataTable koltukrenk1mavi = new DataTable();
            koltukrenkmavi.Fill(koltukrenk1mavi);
            conn.Close();
           
            for (int k = 0; k < koltukrenk1mavi.Rows.Count; k++)
            {
                if (koltukrenk1mavi.Rows[k][1].ToString() == "1" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button1.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "2" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button2.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "3" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button3.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "4" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button4.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "5" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button5.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "6" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button6.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "7" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button7.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "8" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button8.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "9" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button9.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "10" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button10.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "11" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button11.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "12" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button12.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "13" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button13.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "14" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button14.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "15" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button15.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "16" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button16.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "17" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button17.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "18" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button18.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "19" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button19.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "20" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button20.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "21" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button21.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "22" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button22.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "23" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button23.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "24" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button24.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "25" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button25.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "26" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button26.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "27" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button27.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "28" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button28.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "29" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button29.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "30" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button30.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "31" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button31.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "32" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button32.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "33" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button33.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "34" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button34.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "35" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button35.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "36" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button36.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "37" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button37.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "38" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button38.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "39" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button39.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "40" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button40.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "41" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button41.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "42" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button42.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "43" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button43.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "44" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button44.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "45" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button45.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "46" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button46.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "47" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button47.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "48" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button48.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "49" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button49.BackColor = Color.Pink;
                }
                if (koltukrenk1mavi.Rows[k][1].ToString() == "50" && koltukrenk1mavi.Rows[k][8].ToString() == "Kadın")
                {
                    button50.BackColor = Color.Pink;
                }
              
                for (int m = 0; m < koltukrenk1mavi.Rows.Count; m++)
                {
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "1"&&koltukrenk1mavi.Rows[m][8].ToString()=="Erkek")
                    {
                        button1.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "2" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button2.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "3" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button3.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "4" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button4.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "5" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button5.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "6" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button6.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "7" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button7.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "8" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button8.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "9" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button9.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "10" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button10.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "11" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button11.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "12" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button12.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "13" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button13.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "14" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button14.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "15" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button15.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "16" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button16.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "17" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button17.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "18" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button18.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "19" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button19.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "20" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button20.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "21" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button21.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "22" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button22.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "23" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button23.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "24" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button24.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "25" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button25.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "26" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button26.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "27" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button27.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "28" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button28.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "29" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button29.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "30" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button30.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "31" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button31.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "32" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button32.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "33" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button33.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "34" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button34.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "35" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button35.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "36" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button36.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "37" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button37.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "38" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button38.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "39" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button39.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "40" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button40.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "41" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button41.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "42" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button42.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "43" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button43.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "44" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button44.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "45" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button45.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "46" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button46.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "47" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button47.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "48" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button48.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "49" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button49.BackColor = Color.Cyan;
                    }
                    if (koltukrenk1mavi.Rows[m][1].ToString() == "50" && koltukrenk1mavi.Rows[m][8].ToString() == "Erkek")
                    {
                        button50.BackColor = Color.Cyan;
                    }
                }

            }



        }
        public void göster()
        {
             baglanti.Open();

             OleDbDataAdapter adap = new OleDbDataAdapter("select * from koltuklar", baglanti);
             DataTable dt = new DataTable();
             adap.Fill(dt);
             dataGridView1.DataSource = dt;
             baglanti.Close();
        }
        DataTable asd = new DataTable();
        int fiyat = 0;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Koltuklar.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
           
            if(button1.BackColor==Color.Red)
            {
                listBox1.Items.Remove(1);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button1.BackColor = Color.White;             
            }
            else
            {
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                listBox1.Items.Add(1);
                button1.BackColor = Color.Red;
               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (button2.BackColor == Color.Red)
            {
                listBox1.Items.Remove(2);

                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button2.BackColor = Color.White;


            }
            else
            { 
                listBox1.Items.Add(2);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button2.BackColor = Color.Red;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            if (button3.BackColor == Color.Red)
            {listBox1.Items.Remove(3);
            fiyat = fiyat - Convert.ToInt32(label7.Text);
            label33.Text = fiyat.ToString();
                button3.BackColor = Color.White;

            }
            else
            {
                listBox1.Items.Add(3);
                fiyat = fiyat +Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button3.BackColor = Color.Red;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            if (button4.BackColor == Color.Red)
            {listBox1.Items.Remove(4);
            fiyat = fiyat - Convert.ToInt32(label7.Text);
            label33.Text = fiyat.ToString();
                button4.BackColor = Color.White;


            }
            else
            {
                listBox1.Items.Add(4);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button4.BackColor = Color.Red;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Red)
            {
                listBox1.Items.Remove(5);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button5.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 5=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(5);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button5.BackColor = Color.Red;

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (button7.BackColor == Color.Red)
            {listBox1.Items.Remove(7);
            fiyat = fiyat - Convert.ToInt32(label7.Text);
            label33.Text = fiyat.ToString();
                baglanti.Open();
                button7.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 7=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {listBox1.Items.Add(7);
            fiyat = fiyat + Convert.ToInt32(label7.Text);
            label33.Text = fiyat.ToString();
                button7.BackColor = Color.Red;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            
            if (button6.BackColor == Color.Red)
            {  listBox1.Items.Remove(6);
            fiyat = fiyat - Convert.ToInt32(label7.Text);
            label33.Text = fiyat.ToString();
                baglanti.Open();
                button6.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 6=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(6);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button6.BackColor = Color.Red;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (button8.BackColor == Color.Red)
            {
                listBox1.Items.Remove(8);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button8.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 8=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {listBox1.Items.Add(8);
            fiyat = fiyat+ Convert.ToInt32(label7.Text);
            label33.Text = fiyat.ToString();
                button8.BackColor = Color.Red;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (button9.BackColor == Color.Red)
            {
                listBox1.Items.Remove(9);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button9.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 9=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(9);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();

                button9.BackColor = Color.Red;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (button10.BackColor == Color.Red)
            {
                listBox1.Items.Remove(10);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button10.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 10=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {

                listBox1.Items.Add(10);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button10.BackColor = Color.Red;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Red)
            {
                listBox1.Items.Remove(11);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button11.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 11=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(11);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();

                button11.BackColor = Color.Red;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Red)
            {
                listBox1.Items.Remove(12);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button12.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 12=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(12);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();

                button12.BackColor = Color.Red;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Red)
            {
                listBox1.Items.Remove(13);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button13.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 13=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(13);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button13.BackColor = Color.Red;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Red)
            {
                listBox1.Items.Remove(14);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button14.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 14=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(14);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button14.BackColor = Color.Red;

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Red)
            {
                listBox1.Items.Remove(15);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button15.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 15=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(15);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button15.BackColor = Color.Red;

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Red)
            {
                listBox1.Items.Remove(16);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button16.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 16=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(16);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button16.BackColor = Color.Red;;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Red)
            {
                listBox1.Items.Remove(17);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button17.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 17=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(17);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();

                button17.BackColor = Color.Red;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.Red)
            {
                listBox1.Items.Remove(18);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button18.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 18=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(18);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button18.BackColor = Color.Red;

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.Red)
            {
                listBox1.Items.Remove(19);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button19.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 19=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(19);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button19.BackColor = Color.Red;

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.Red)
            {
                listBox1.Items.Remove(20);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button20.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 20=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(20);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();

                button20.BackColor = Color.Red;

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.Red)
            {

                listBox1.Items.Remove(21);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button21.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 21=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(21);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button21.BackColor = Color.Red;

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.Red)
            {
                listBox1.Items.Remove(22);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button22.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 22=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(22);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button22.BackColor = Color.Red;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.Red)
            {
                listBox1.Items.Remove(23);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button23.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 23=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(23);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();

                button23.BackColor = Color.Red;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.Red)
            {
                listBox1.Items.Remove(24);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button24.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 24=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(24);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button24.BackColor = Color.Red;

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.Red)
            {
                listBox1.Items.Remove(25);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button25.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 25=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(25);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button25.BackColor = Color.Red;

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == Color.Red)
            {

                listBox1.Items.Remove(26);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button26.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 26=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(26);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button26.BackColor = Color.Red;

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == Color.Red)
            {
                listBox1.Items.Remove(27);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button27.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 27=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(27);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();

                button27.BackColor = Color.Red;

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == Color.Red)
            {
                listBox1.Items.Remove(28);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button28.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 28=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(28);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button28.BackColor = Color.Red;
              

            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.BackColor == Color.Red)
            {
                listBox1.Items.Remove(29);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button29.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 29=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(29);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button29.BackColor = Color.Red;
               

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.BackColor == Color.Red)
            {
                listBox1.Items.Remove(30);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button30.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 30=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(30);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button30.BackColor = Color.Red;
              

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.BackColor == Color.Red)
            {
                listBox1.Items.Remove(31);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button31.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 31=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(31);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button31.BackColor = Color.Red;
             

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.BackColor == Color.Red)
            {
                listBox1.Items.Remove(32);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button32.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 32=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(32);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button32.BackColor = Color.Red;
           

            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == Color.Red)
            {
                listBox1.Items.Remove(33);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button33.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 33=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(33);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button33.BackColor = Color.Red;
           

            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.BackColor == Color.Red)
            {
                listBox1.Items.Remove(34);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button34.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 34=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(34);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button34.BackColor = Color.Red;
              

            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == Color.Red)
            {
                listBox1.Items.Remove(35);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button35.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 35=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(35);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button35.BackColor = Color.Red;
             

            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.BackColor == Color.Red)
            {
                listBox1.Items.Remove(36);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button36.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 36=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(36);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button36.BackColor = Color.Red;
               
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (button37.BackColor == Color.Red)
            {
                listBox1.Items.Remove(37);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button37.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 37=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(37);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button37.BackColor = Color.Red;
                

            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button38.BackColor == Color.Red)
            {
                listBox1.Items.Remove(38);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button38.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 38=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(38);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button38.BackColor = Color.Red;
               

            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (button39.BackColor == Color.Red)
            {
                listBox1.Items.Remove(39);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button39.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 39=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(39);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button39.BackColor = Color.Red;
               

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button40.BackColor == Color.Red)
            {
                listBox1.Items.Remove(40);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button40.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 40=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(40);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button40.BackColor = Color.Red;
             

            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (button41.BackColor == Color.Red)
            {
                listBox1.Items.Remove(41);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button41.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 41=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(41);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button41.BackColor = Color.Red;
               

            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (button42.BackColor == Color.Red)
            {
                listBox1.Items.Remove(42);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button42.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 42=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(42);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button42.BackColor = Color.Red;
            

            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (button43.BackColor == Color.Red)
            {
                listBox1.Items.Remove(43);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button43.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 43=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(43);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button43.BackColor = Color.Red;
                

            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button44.BackColor == Color.Red)
            {
                listBox1.Items.Remove(44);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button44.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 44=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(44);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button44.BackColor = Color.Red;
               

            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (button45.BackColor == Color.Red)
            {
                listBox1.Items.Remove(45);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button45.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 45=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {

                listBox1.Items.Add(45);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button45.BackColor = Color.Red;
             

            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (button46.BackColor == Color.Red)
            {
                listBox1.Items.Remove(46);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button46.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 46=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(46);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button46.BackColor = Color.Red;
                

            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (button47.BackColor == Color.Red)
            {
                listBox1.Items.Remove(47);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button47.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 47=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(47);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button47.BackColor = Color.Red;
                

            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (button48.BackColor == Color.Red)
            {
                listBox1.Items.Remove(48);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button48.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 48=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(48);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button48.BackColor = Color.Red;
               

            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (button49.BackColor == Color.Red)
            {
                listBox1.Items.Remove(49);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button49.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 49=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(49);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button49.BackColor = Color.Red;
               

            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (button50.BackColor == Color.Red)
            {
                listBox1.Items.Remove(50);
                fiyat = fiyat - Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                baglanti.Open();
                button50.BackColor = Color.White;

                OleDbCommand ekle = new OleDbCommand("update koltuklar set 50=" + 0 + " where seferno='" + label19.Text + "'", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                göster();

            }
            else
            {
                listBox1.Items.Add(50);
                fiyat = fiyat + Convert.ToInt32(label7.Text);
                label33.Text = fiyat.ToString();
                button50.BackColor = Color.Red;
                

            }
        }
        
        
        string kltk;
        OleDbCommand ekl2;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Yedek - satilankoltuk.accdb");
        private void button51_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                baglanti.Close();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    conn.Close();
                    conn.Open();
                    if (radioButton1.Checked == true)
                    {
                        ekl2 = new OleDbCommand("insert into satilankoltuk(koltuk_no,adı,soyadı,tc,telefon,id,fiyat,cinsiyet)values('" + listBox1.Items[i].ToString() + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + label19.Text + "','" + label7.Text + "','" + "Erkek" + "')", conn);
                    }
                    if (radioButton2.Checked == true) 
                    {
                        ekl2 = new OleDbCommand("insert into satilankoltuk(koltuk_no,adı,soyadı,tc,telefon,id,fiyat,cinsiyet)values('" + listBox1.Items[i].ToString() + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + label19.Text + "','" + label7.Text + "','" + "Kadın" + "')", conn);
                    }
                    ekl2.ExecuteNonQuery();
                    conn.Close();
                    kltk = kltk + listBox1.Items[i].ToString() + ", ";
                    baglanti.Open();
                    OleDbCommand ekle = new OleDbCommand("update koltuklar set " + listBox1.Items[i].ToString() + "=" + 1 + " where seferno='" + label19.Text + "'", baglanti);
                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            
            
            
            MessageBox.Show(textBox1.Text + " Adına Sahip Müşteri " + kltk + " Nolu Koltukları Satın Aldı. Borcunuz = " + label33.Text + ". Furkan Turizm İyi Günler Diler");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label33.Text = "0";
            fiyat = 0;
            kltk = "";
            
            
           
            if (button1.BackColor == Color.Red)
            {
                button1.Enabled = false;
            }
            if (button2.BackColor == Color.Red)
            {
                button2.Enabled = false;
            }
            if (button3.BackColor == Color.Red)
            {
                button3.Enabled = false;
            }
            if (button4.BackColor == Color.Red)
            {
                button4.Enabled = false;
            }
            if (button5.BackColor == Color.Red)
            {
                button5.Enabled = false;
            }
            if (button6.BackColor == Color.Red)
            {
                button6.Enabled = false;
            }
            if (button7.BackColor == Color.Red)
            {
                button7.Enabled = false;
            }
            if (button8.BackColor == Color.Red)
            {
                button8.Enabled = false;
            }
            if (button9.BackColor == Color.Red)
            {
                button9.Enabled = false;
            }
            if (button10.BackColor == Color.Red)
            {
                button10.Enabled = false;
            }
            if (button11.BackColor == Color.Red)
            {
                button11.Enabled = false;
            }
            if (button12.BackColor == Color.Red)
            {
                button12.Enabled = false;
            }
            if (button13.BackColor == Color.Red)
            {
                button13.Enabled = false;
            }
            if (button14.BackColor == Color.Red)
            {
                button14.Enabled = false;
            }
            if (button15.BackColor == Color.Red)
            {
                button15.Enabled = false;
            }
            if (button16.BackColor == Color.Red)
            {
                button16.Enabled = false;
            }
            if (button17.BackColor == Color.Red)
            {
                button17.Enabled = false;
            }
            if (button18.BackColor == Color.Red)
            {
                button18.Enabled = false;
            }
            if (button19.BackColor == Color.Red)
            {
                button19.Enabled = false;
            }
            if (button18.BackColor == Color.Red)
            {
                button18.Enabled = false;
            }
            if (button19.BackColor == Color.Red)
            {
                button19.Enabled = false;
            }
            if (button20.BackColor == Color.Red)
            {
                button20.Enabled = false;
            }
            if (button21.BackColor == Color.Red)
            {
                button21.Enabled = false;
            }
            if (button22.BackColor == Color.Red)
            {
                button22.Enabled = false;
            }
            if (button23.BackColor == Color.Red)
            {
                button23.Enabled = false;
            }
            if (button24.BackColor == Color.Red)
            {
                button24.Enabled = false;
            }
            if (button25.BackColor == Color.Red)
            {
                button25.Enabled = false;
            }
            if (button26.BackColor == Color.Red)
            {
                button26.Enabled = false;
            }
            if (button27.BackColor == Color.Red)
            {
                button27.Enabled = false;
            }
            if (button28.BackColor == Color.Red)
            {
                button28.Enabled = false;
            }
            if (button29.BackColor == Color.Red)
            {
                button29.Enabled = false;
            }
            if (button30.BackColor == Color.Red)
            {
                button30.Enabled = false;
            }
            if (button31.BackColor == Color.Red)
            {
                button31.Enabled = false;
            }
            if (button32.BackColor == Color.Red)
            {
                button32.Enabled = false;
            }
            if (button33.BackColor == Color.Red)
            {
                button33.Enabled = false;
            }
            if (button34.BackColor == Color.Red)
            {
                button34.Enabled = false;
            }
            if (button35.BackColor == Color.Red)
            {
                button35.Enabled = false;
            }
            if (button36.BackColor == Color.Red)
            {
                button36.Enabled = false;
            }
            if (button37.BackColor == Color.Red)
            {
                button37.Enabled = false;
            }
            if (button38.BackColor == Color.Red)
            {
                button38.Enabled = false;
            }
            if (button39.BackColor == Color.Red)
            {
                button39.Enabled = false;
            }
            if (button40.BackColor == Color.Red)
            {
                button40.Enabled = false;
            }
            if (button41.BackColor == Color.Red)
            {
                button41.Enabled = false;
            }
            if (button42.BackColor == Color.Red)
            {
                button42.Enabled = false;
            }
            if (button43.BackColor == Color.Red)
            {
                button43.Enabled = false;
            }
            if (button44.BackColor == Color.Red)
            {
                button44.Enabled = false;
            }
            if (button45.BackColor == Color.Red)
            {
                button45.Enabled = false;
            }
            if (button46.BackColor == Color.Red)
            {
                button46.Enabled = false;
            }
            if (button47.BackColor == Color.Red)
            {
                button47.Enabled = false;
            }
            if (button48.BackColor == Color.Red)
            {
                button48.Enabled = false;
            }
            if (button49.BackColor == Color.Red)
            {
                button49.Enabled = false;
            }
            if (button50.BackColor == Color.Red)
            {
                button50.Enabled = false;
            }
            for (int l = 0; l < listBox1.Items.Count; l++)
            {
                if (listBox1.Items[l].ToString() == "1" && radioButton1.Checked == true)
                {
                    button1.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "2" && radioButton1.Checked == true)
                {
                    button2.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "3" && radioButton1.Checked == true)
                {
                    button3.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "4" && radioButton1.Checked == true)
                {
                    button4.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "5" && radioButton1.Checked == true)
                {
                    button5.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "6" && radioButton1.Checked == true)
                {
                    button6.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "7" && radioButton1.Checked == true)
                {
                    button7.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "8" && radioButton1.Checked == true)
                {
                    button8.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "9" && radioButton1.Checked == true)
                {
                    button9.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "10" && radioButton1.Checked == true)
                {
                    button10.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "11" && radioButton1.Checked == true)
                {
                    button11.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "12" && radioButton1.Checked == true)
                {
                    button12.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "13" && radioButton1.Checked == true)
                {
                    button13.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "14" && radioButton1.Checked == true)
                {
                    button14.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "15" && radioButton1.Checked == true)
                {
                    button15.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "16" && radioButton1.Checked == true)
                {
                    button16.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "17" && radioButton1.Checked == true)
                {
                    button17.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "18" && radioButton1.Checked == true)
                {
                    button18.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "19" && radioButton1.Checked == true)
                {
                    button19.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "20" && radioButton1.Checked == true)
                {
                    button20.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "21" && radioButton1.Checked == true)
                {
                    button21.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "22" && radioButton1.Checked == true)
                {
                    button22.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "23" && radioButton1.Checked == true)
                {
                    button23.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "24" && radioButton1.Checked == true)
                {
                    button24.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "25" && radioButton1.Checked == true)
                {
                    button25.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "26" && radioButton1.Checked == true)
                {
                    button26.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "27" && radioButton1.Checked == true)
                {
                    button27.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "28" && radioButton1.Checked == true)
                {
                    button28.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "29" && radioButton1.Checked == true)
                {
                    button29.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "30" && radioButton1.Checked == true)
                {
                    button30.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "31" && radioButton1.Checked == true)
                {
                    button31.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "32" && radioButton1.Checked == true)
                {
                    button32.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "33" && radioButton1.Checked == true)
                {
                    button33.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "34" && radioButton1.Checked == true)
                {
                    button34.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "35" && radioButton1.Checked == true)
                {
                    button35.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "36" && radioButton1.Checked == true)
                {
                    button36.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "37" && radioButton1.Checked == true)
                {
                    button37.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "38" && radioButton1.Checked == true)
                {
                    button38.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "39" && radioButton1.Checked == true)
                {
                    button39.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "40" && radioButton1.Checked == true)
                {
                    button40.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "41" && radioButton1.Checked == true)
                {
                    button41.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "42" && radioButton1.Checked == true)
                {
                    button42.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "43" && radioButton1.Checked == true)
                {
                    button43.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "44" && radioButton1.Checked == true)
                {
                    button44.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "45" && radioButton1.Checked == true)
                {
                    button45.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "46" && radioButton1.Checked == true)
                {
                    button46.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "47" && radioButton1.Checked == true)
                {
                    button47.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "48" && radioButton1.Checked == true)
                {
                    button48.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "49" && radioButton1.Checked == true)
                {
                    button49.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "50" && radioButton1.Checked == true)
                {
                    button50.BackColor = Color.Cyan;
                }
                if (listBox1.Items[l].ToString() == "1" && radioButton2.Checked == true)
                {
                    button1.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "2" && radioButton2.Checked == true)
                {
                    button2.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "3" && radioButton2.Checked == true)
                {
                    button3.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "4" && radioButton2.Checked == true)
                {
                    button4.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "5" && radioButton2.Checked == true)
                {
                    button5.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "6" && radioButton2.Checked == true)
                {
                    button6.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "7" && radioButton2.Checked == true)
                {
                    button7.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "8" && radioButton2.Checked == true)
                {
                    button8.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "9" && radioButton2.Checked == true)
                {
                    button9.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "10" && radioButton2.Checked == true)
                {
                    button10.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "11" && radioButton2.Checked == true)
                {
                    button11.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "12" && radioButton2.Checked == true)
                {
                    button12.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "13" && radioButton2.Checked == true)
                {
                    button13.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "14" && radioButton2.Checked == true)
                {
                    button14.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "15" && radioButton2.Checked == true)
                {
                    button15.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "16" && radioButton2.Checked == true)
                {
                    button16.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "17" && radioButton2.Checked == true)
                {
                    button17.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "18" && radioButton2.Checked == true)
                {
                    button18.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "19" && radioButton2.Checked == true)
                {
                    button19.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "20" && radioButton2.Checked == true)
                {
                    button20.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "21" && radioButton2.Checked == true)
                {
                    button21.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "22" && radioButton2.Checked == true)
                {
                    button22.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "23" && radioButton2.Checked == true)
                {
                    button23.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "24" && radioButton2.Checked == true)
                {
                    button24.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "25" && radioButton2.Checked == true)
                {
                    button25.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "26" && radioButton2.Checked == true)
                {
                    button26.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "27" && radioButton2.Checked == true)
                {
                    button27.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "28" && radioButton2.Checked == true)
                {
                    button28.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "29" && radioButton2.Checked == true)
                {
                    button29.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "30" && radioButton2.Checked == true)
                {
                    button30.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "31" && radioButton2.Checked == true)
                {
                    button31.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "32" && radioButton2.Checked == true)
                {
                    button32.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "33" && radioButton2.Checked == true)
                {
                    button33.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "34" && radioButton2.Checked == true)
                {
                    button34.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "35" && radioButton2.Checked == true)
                {
                    button35.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "36" && radioButton2.Checked == true)
                {
                    button36.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "37" && radioButton2.Checked == true)
                {
                    button37.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "38" && radioButton2.Checked == true)
                {
                    button38.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "39" && radioButton2.Checked == true)
                {
                    button39.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "40" && radioButton2.Checked == true)
                {
                    button40.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "41" && radioButton2.Checked == true)
                {
                    button41.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "42" && radioButton2.Checked == true)
                {
                    button42.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "43" && radioButton2.Checked == true)
                {
                    button43.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "44" && radioButton2.Checked == true)
                {
                    button44.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "45" && radioButton2.Checked == true)
                {
                    button45.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "46" && radioButton2.Checked == true)
                {
                    button46.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "47" && radioButton2.Checked == true)
                {
                    button47.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "48" && radioButton2.Checked == true)
                {
                    button48.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "49" && radioButton2.Checked == true)
                {
                    button49.BackColor = Color.Pink;
                }
                if (listBox1.Items[l].ToString() == "50" && radioButton2.Checked == true)
                {
                    button50.BackColor = Color.Pink;
                }
            }
            listBox1.Items.Clear();
            

        }

        private void button52_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataAdapter yeah = new OleDbDataAdapter("Select*from satilankoltuk where koltuk_no='" + textBox5.Text + "'", conn);
                DataTable tablo1 = new DataTable();
                yeah.Fill(tablo1);
                label28.Text = tablo1.Rows[0][2].ToString();
                label29.Text = tablo1.Rows[0][3].ToString();
                label30.Text = tablo1.Rows[0][4].ToString();
                label31.Text = tablo1.Rows[0][6].ToString();
                
            }
            catch
            {
                MessageBox.Show("Seçtiğiniz koltuk boş gözüküyor");
            }
            conn.Close();
           
        }

        private void button53_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand satilankltuksil = new OleDbCommand("Delete from satilankoltuk where koltuk_no='" + textBox6.Text + "'", conn);
            satilankltuksil.ExecuteNonQuery();
            conn.Close();
            baglanti.Open();
            OleDbCommand gncellekltk = new OleDbCommand("update koltuklar set " + textBox6.Text + "='" + 0 + "' where seferno='" + label19.Text + "'", baglanti);
            gncellekltk.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(textBox6.Text+" numaralı koltuk iptal edilmiştir");
            if (textBox6.Text == "1")
            {
                button1.Enabled = true;
                button1.BackColor = Color.White;
            }
            if (textBox6.Text == "2")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
            if (textBox6.Text == "3")
            {
                button3.Enabled = true;
                button3.BackColor = Color.White;
            }
            if (textBox6.Text == "4")
            {
                button4.Enabled = true;
                button4.BackColor = Color.White;
            }
            if (textBox6.Text == "5")
            {
                button5.Enabled = true;
                button5.BackColor = Color.White;
            }
            if (textBox6.Text == "6")
            {
                button6.Enabled = true;
                button6.BackColor = Color.White;
            }
            if (textBox6.Text == "7")
            {
                button7.Enabled = true;
                button7.BackColor = Color.White;
            }
            if (textBox6.Text == "8")
            {
                button8.Enabled = true;
                button8.BackColor = Color.White;
            }
            if (textBox6.Text == "9")
            {
                button9.Enabled = true;
                button9.BackColor = Color.White;
            }
            if (textBox6.Text == "10")
            {
                button10.Enabled = true;
                button10.BackColor = Color.White;
            }
            if (textBox6.Text == "11")
            {
                button11.Enabled = true;
                button11.BackColor = Color.White;
            }
            if (textBox6.Text == "12")
            {
                button12.Enabled = true;
                button12.BackColor = Color.White;
            }
            if (textBox6.Text == "13")
            {
                button13.Enabled = true;
                button13.BackColor = Color.White;
            }
            if (textBox6.Text == "14")
            {
                button14.Enabled = true;
                button14.BackColor = Color.White;
            }
            if (textBox6.Text == "15")
            {
                button15.Enabled = true;
                button15.BackColor = Color.White;
            }
            if (textBox6.Text == "16")
            {
                button16.Enabled = true;
                button16.BackColor = Color.White;
            }
            if (textBox6.Text == "17")
            {
                button17.Enabled = true;
                button17.BackColor = Color.White;
            }
            if (textBox6.Text == "18")
            {
                button18.Enabled = true;
                button18.BackColor = Color.White;
            }
            if (textBox6.Text == "19")
            {
                button19.Enabled = true;
                button19.BackColor = Color.White;
            }
            if (textBox6.Text == "20")
            {
                button20.Enabled = true;
                button20.BackColor = Color.White;
            }
            if (textBox6.Text == "21")
            {
                button21.Enabled = true;
                button21.BackColor = Color.White;
            }
            if (textBox6.Text == "22")
            {
                button22.Enabled = true;
                button22.BackColor = Color.White;
            }
            if (textBox6.Text == "23")
            {
                button23.Enabled = true;
                button23.BackColor = Color.White;
            }
            if (textBox6.Text == "24")
            {
                button24.Enabled = true;
                button24.BackColor = Color.White;
            }
            if (textBox6.Text == "25")
            {
                button25.Enabled = true;
                button25.BackColor = Color.White;
            }
            if (textBox6.Text == "26")
            {
                button26.Enabled = true;
                button26.BackColor = Color.White;
            }
            if (textBox6.Text == "27")
            {
                button27.Enabled = true;
                button27.BackColor = Color.White;
            }
            if (textBox6.Text == "28")
            {
                button28.Enabled = true;
                button28.BackColor = Color.White;
            }
            if (textBox6.Text == "29")
            {
                button29.Enabled = true;
                button29.BackColor = Color.White;
            }
            if (textBox6.Text == "30")
            {
                button30.Enabled = true;
                button30.BackColor = Color.White;
            }
            if (textBox6.Text == "31")
            {
                button31.Enabled = true;
                button31.BackColor = Color.White;
            }
            if (textBox6.Text == "32")
            {
                button32.Enabled = true;
                button32.BackColor = Color.White;
            }
            if (textBox6.Text == "33")
            {
                button33.Enabled = true;
                button33.BackColor = Color.White;
            }
            if (textBox6.Text == "34")
            {
                button34.Enabled = true;
                button34.BackColor = Color.White;
            }
            if (textBox6.Text == "35")
            {
                button35.Enabled = true;
                button35.BackColor = Color.White;
            }
            if (textBox6.Text == "36")
            {
                button36.Enabled = true;
                button36.BackColor = Color.White;
            }
            if (textBox6.Text == "37")
            {
                button37.Enabled = true;
                button37.BackColor = Color.White;
            }
            if (textBox6.Text == "38")
            {
                button38.Enabled = true;
                button38.BackColor = Color.White;
            }
            if (textBox6.Text == "39")
            {
                button39.Enabled = true;
                button39.BackColor = Color.White;
            }
            if (textBox6.Text == "40")
            {
                button40.Enabled = true;
                button40.BackColor = Color.White;
            }
            if (textBox6.Text == "41")
            {
                button41.Enabled = true;
                button41.BackColor = Color.White;
            }
            if (textBox6.Text == "42")
            {
                button42.Enabled = true;
                button42.BackColor = Color.White;
            }
            if (textBox6.Text == "43")
            {
                button43.Enabled = true;
                button43.BackColor = Color.White;
            }
            if (textBox6.Text == "44")
            {
                button44.Enabled = true;
                button44.BackColor = Color.White;
            }
            if (textBox6.Text == "45")
            {
                button45.Enabled = true;
                button45.BackColor = Color.White;
            }
            if (textBox6.Text == "46")
            {
                button46.Enabled = true;
                button46.BackColor = Color.White;
            }
            if (textBox6.Text == "47")
            {
                button47.Enabled = true;
                button47.BackColor = Color.White;
            }
            if (textBox6.Text == "48")
            {
                button48.Enabled = true;
                button48.BackColor = Color.White;
            }
            if (textBox6.Text == "49")
            {
                button49.Enabled = true;
                button49.BackColor = Color.White;
            }
            if (textBox6.Text == "50")
            {
                button50.Enabled = true;
                button50.BackColor = Color.White;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
    }
}
