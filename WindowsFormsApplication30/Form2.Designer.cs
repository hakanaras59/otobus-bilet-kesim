namespace WindowsFormsApplication30
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01 Adana",
            "02 Adıyaman",
            "03 Afyon",
            "04 Ağrı",
            "05 Amasya",
            "06 Ankara",
            "07 Antalya",
            "08 Artvin",
            "09 Aydın",
            "10 Balıkesir",
            "11 Bilecik",
            "12 Bingöl",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir",
            "27 Gaziantep",
            "28 Giresun",
            "29 Gümüşhane",
            "30 Hakkari",
            "31 Hatay",
            "32 Isparta",
            "33 İçel (Mersin)",
            "34 İstanbul",
            "35 İzmir",
            "36 Kars",
            "37 Kastamonu",
            "38 Kayseri",
            "39 Kırklareli",
            "40 Kırşehir",
            "41 Kocaeli",
            "42 Konya",
            "43 Kütahya",
            "44 Malatya",
            "45 Manisa",
            "46 K.maraş",
            "47 Mardin",
            "48 Muğla",
            "49 Muş",
            "50 Nevşehir",
            "51 Niğde",
            "52 Ordu",
            "53 Rize",
            "54 Sakarya",
            "55 Samsun",
            "56 Siirt",
            "57 Sinop",
            "58 Sivas",
            "59 Tekirdağ",
            "60 Tokat",
            "61 Trabzon",
            "62 Tunceli",
            "63 Şanlıurfa",
            "64 Uşak",
            "65 Van",
            "66 Yozgat",
            "67 Zonguldak",
            "68 Aksaray",
            "69 Bayburt",
            "70 Karaman",
            "71 Kırıkkale",
            "72 Batman",
            "73 Şırnak",
            "74 Bartın",
            "75 Ardahan",
            "76 Iğdır",
            "77 Yalova",
            "78 Karabük",
            "79 Kilis",
            "80 Osmaniye",
            "81 Düzce"});
            this.comboBox1.Location = new System.Drawing.Point(98, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01 Adana",
            "02 Adıyaman",
            "03 Afyon",
            "04 Ağrı",
            "05 Amasya",
            "06 Ankara",
            "07 Antalya",
            "08 Artvin",
            "09 Aydın",
            "10 Balıkesir",
            "11 Bilecik",
            "12 Bingöl",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir",
            "27 Gaziantep",
            "28 Giresun",
            "29 Gümüşhane",
            "30 Hakkari",
            "31 Hatay",
            "32 Isparta",
            "33 İçel (Mersin)",
            "34 İstanbul",
            "35 İzmir",
            "36 Kars",
            "37 Kastamonu",
            "38 Kayseri",
            "39 Kırklareli",
            "40 Kırşehir",
            "41 Kocaeli",
            "42 Konya",
            "43 Kütahya",
            "44 Malatya",
            "45 Manisa",
            "46 K.maraş",
            "47 Mardin",
            "48 Muğla",
            "49 Muş",
            "50 Nevşehir",
            "51 Niğde",
            "52 Ordu",
            "53 Rize",
            "54 Sakarya",
            "55 Samsun",
            "56 Siirt",
            "57 Sinop",
            "58 Sivas",
            "59 Tekirdağ",
            "60 Tokat",
            "61 Trabzon",
            "62 Tunceli",
            "63 Şanlıurfa",
            "64 Uşak",
            "65 Van",
            "66 Yozgat",
            "67 Zonguldak",
            "68 Aksaray",
            "69 Bayburt",
            "70 Karaman",
            "71 Kırıkkale",
            "72 Batman",
            "73 Şırnak",
            "74 Bartın",
            "75 Ardahan",
            "76 Iğdır",
            "77 Yalova",
            "78 Karabük",
            "79 Kilis",
            "80 Osmaniye",
            "81 Düzce"});
            this.comboBox2.Location = new System.Drawing.Point(98, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nereden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereye";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::WindowsFormsApplication30.Properties.Resources.bir1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(282, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.comboBox3.Location = new System.Drawing.Point(98, 182);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(0, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tarih";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "TRAVEGO 54",
            "TRAVEGO 46",
            "SETRA 46",
            "SETRA 54",
            "TEMSA SAFİR",
            "MAN FORTUNA",
            "NEOPLAN CİTYLİNER",
            "NEOPLAN STARLİNER",
            "TRAVEGO 2+1"});
            this.comboBox4.Location = new System.Drawing.Point(98, 223);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(0, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Otobüs Tipi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 264);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fiyat";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(0, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sefer No";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Location = new System.Drawing.Point(394, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "<---";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication30.Properties.Resources.Travel_Bus__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Sefer Ekle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.ComboBox comboBox4;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}