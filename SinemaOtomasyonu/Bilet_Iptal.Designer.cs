namespace SinemaOtomasyonu
{
    partial class Bilet_Iptal
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biletIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltukNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaDataSet = new SinemaOtomasyonu.sinemaDataSet();
            this.bILETTableAdapter = new SinemaOtomasyonu.sinemaDataSetTableAdapters.BILETTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 43);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(891, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "BİLET SİL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biletIDDataGridViewTextBoxColumn,
            this.filmIDDataGridViewTextBoxColumn,
            this.salonIDDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.seansDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.koltukNoDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bILETBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(180, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 283);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // biletIDDataGridViewTextBoxColumn
            // 
            this.biletIDDataGridViewTextBoxColumn.DataPropertyName = "Bilet_ID";
            this.biletIDDataGridViewTextBoxColumn.HeaderText = "Bilet_ID";
            this.biletIDDataGridViewTextBoxColumn.Name = "biletIDDataGridViewTextBoxColumn";
            // 
            // filmIDDataGridViewTextBoxColumn
            // 
            this.filmIDDataGridViewTextBoxColumn.DataPropertyName = "Film_ID";
            this.filmIDDataGridViewTextBoxColumn.HeaderText = "Film_ID";
            this.filmIDDataGridViewTextBoxColumn.Name = "filmIDDataGridViewTextBoxColumn";
            // 
            // salonIDDataGridViewTextBoxColumn
            // 
            this.salonIDDataGridViewTextBoxColumn.DataPropertyName = "Salon_ID";
            this.salonIDDataGridViewTextBoxColumn.HeaderText = "Salon_ID";
            this.salonIDDataGridViewTextBoxColumn.Name = "salonIDDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // seansDataGridViewTextBoxColumn
            // 
            this.seansDataGridViewTextBoxColumn.DataPropertyName = "Seans";
            this.seansDataGridViewTextBoxColumn.HeaderText = "Seans";
            this.seansDataGridViewTextBoxColumn.Name = "seansDataGridViewTextBoxColumn";
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "Ad_Soyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "Ad_Soyad";
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            // 
            // koltukNoDataGridViewTextBoxColumn
            // 
            this.koltukNoDataGridViewTextBoxColumn.DataPropertyName = "Koltuk_No";
            this.koltukNoDataGridViewTextBoxColumn.HeaderText = "Koltuk_No";
            this.koltukNoDataGridViewTextBoxColumn.Name = "koltukNoDataGridViewTextBoxColumn";
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            // 
            // bILETBindingSource
            // 
            this.bILETBindingSource.DataMember = "BILET";
            this.bILETBindingSource.DataSource = this.sinemaDataSet;
            // 
            // sinemaDataSet
            // 
            this.sinemaDataSet.DataSetName = "sinemaDataSet";
            this.sinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bILETTableAdapter
            // 
            this.bILETTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID : ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(51, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bilet_Iptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 441);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bilet_Iptal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet_Iptal";
            this.Load += new System.EventHandler(this.Bilet_Iptal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sinemaDataSet sinemaDataSet;
        private System.Windows.Forms.BindingSource bILETBindingSource;
        private sinemaDataSetTableAdapters.BILETTableAdapter bILETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltukNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}