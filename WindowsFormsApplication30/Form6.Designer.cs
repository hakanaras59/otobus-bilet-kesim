namespace WindowsFormsApplication30
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.kimlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.database10DataSet4 = new WindowsFormsApplication30.Database10DataSet4();
            this.kimlikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kimlikTableAdapter1 = new WindowsFormsApplication30.Database10DataSet4TableAdapters.kimlikTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sefernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neredenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nereyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otobustipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimlikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database10DataSet5 = new WindowsFormsApplication30.Database10DataSet5();
            this.kimlikTableAdapter2 = new WindowsFormsApplication30.Database10DataSet5TableAdapters.kimlikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database10DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database10DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // kimlikBindingSource
            // 
            this.kimlikBindingSource.DataMember = "kimlik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(157, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nereden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(310, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nereye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(454, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bilet Satın Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database10DataSet4
            // 
            this.database10DataSet4.DataSetName = "Database10DataSet4";
            this.database10DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kimlikBindingSource1
            // 
            this.kimlikBindingSource1.DataMember = "kimlik";
            this.kimlikBindingSource1.DataSource = this.database10DataSet4;
            // 
            // kimlikTableAdapter1
            // 
            this.kimlikTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sefernoDataGridViewTextBoxColumn,
            this.neredenDataGridViewTextBoxColumn,
            this.nereyeDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn,
            this.otobustipiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kimlikBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(703, 303);
            this.dataGridView1.TabIndex = 8;
            // 
            // sefernoDataGridViewTextBoxColumn
            // 
            this.sefernoDataGridViewTextBoxColumn.DataPropertyName = "Seferno";
            this.sefernoDataGridViewTextBoxColumn.HeaderText = "Seferno";
            this.sefernoDataGridViewTextBoxColumn.Name = "sefernoDataGridViewTextBoxColumn";
            // 
            // neredenDataGridViewTextBoxColumn
            // 
            this.neredenDataGridViewTextBoxColumn.DataPropertyName = "Nereden";
            this.neredenDataGridViewTextBoxColumn.HeaderText = "Nereden";
            this.neredenDataGridViewTextBoxColumn.Name = "neredenDataGridViewTextBoxColumn";
            // 
            // nereyeDataGridViewTextBoxColumn
            // 
            this.nereyeDataGridViewTextBoxColumn.DataPropertyName = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.HeaderText = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.Name = "nereyeDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "Saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "Saat";
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            // 
            // otobustipiDataGridViewTextBoxColumn
            // 
            this.otobustipiDataGridViewTextBoxColumn.DataPropertyName = "Otobustipi";
            this.otobustipiDataGridViewTextBoxColumn.HeaderText = "Otobustipi";
            this.otobustipiDataGridViewTextBoxColumn.Name = "otobustipiDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // kimlikBindingSource2
            // 
            this.kimlikBindingSource2.DataMember = "kimlik";
            this.kimlikBindingSource2.DataSource = this.database10DataSet5;
            // 
            // database10DataSet5
            // 
            this.database10DataSet5.DataSetName = "Database10DataSet5";
            this.database10DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kimlikTableAdapter2
            // 
            this.kimlikTableAdapter2.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Sefer Seç";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kimlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database10DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database10DataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.BindingSource kimlikBindingSource;
   
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private Database10DataSet4 database10DataSet4;
        private System.Windows.Forms.BindingSource kimlikBindingSource1;
        private Database10DataSet4TableAdapters.kimlikTableAdapter kimlikTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database10DataSet5 database10DataSet5;
        private System.Windows.Forms.BindingSource kimlikBindingSource2;
        private Database10DataSet5TableAdapters.kimlikTableAdapter kimlikTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sefernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neredenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nereyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otobustipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}