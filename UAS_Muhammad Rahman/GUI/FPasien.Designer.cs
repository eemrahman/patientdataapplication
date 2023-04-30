namespace UAS_Muhammad_Rahman.GUI
{
    partial class FPasien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_cari = new System.Windows.Forms.Label();
            this.tb_cari = new System.Windows.Forms.TextBox();
            this.ListPasien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.lbl_nopasien = new System.Windows.Forms.Label();
            this.tb_alamatpasien = new System.Windows.Forms.TextBox();
            this.lbl_namapasien = new System.Windows.Forms.Label();
            this.tb_namapasien = new System.Windows.Forms.TextBox();
            this.lbl_alamatpasien = new System.Windows.Forms.Label();
            this.tb_nopasien = new System.Windows.Forms.TextBox();
            this.lbl_datapasien = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListRiwayat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListPasien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 392);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_cari);
            this.groupBox2.Controls.Add(this.tb_cari);
            this.groupBox2.Controls.Add(this.ListPasien);
            this.groupBox2.Location = new System.Drawing.Point(496, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 225);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tampil Data";
            // 
            // lbl_cari
            // 
            this.lbl_cari.AutoSize = true;
            this.lbl_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cari.Location = new System.Drawing.Point(6, 195);
            this.lbl_cari.Name = "lbl_cari";
            this.lbl_cari.Size = new System.Drawing.Size(103, 24);
            this.lbl_cari.TabIndex = 5;
            this.lbl_cari.Text = "Cari Nama ";
            // 
            // tb_cari
            // 
            this.tb_cari.Location = new System.Drawing.Point(115, 197);
            this.tb_cari.Name = "tb_cari";
            this.tb_cari.Size = new System.Drawing.Size(334, 22);
            this.tb_cari.TabIndex = 4;
            this.tb_cari.TextChanged += new System.EventHandler(this.tb_cari_TextChanged);
            // 
            // ListPasien
            // 
            this.ListPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPasien.Location = new System.Drawing.Point(7, 19);
            this.ListPasien.Name = "ListPasien";
            this.ListPasien.RowTemplate.Height = 24;
            this.ListPasien.Size = new System.Drawing.Size(442, 172);
            this.ListPasien.TabIndex = 0;
            this.ListPasien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPasien_CellClick_1);
            this.ListPasien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPasien_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_hapus);
            this.groupBox1.Controls.Add(this.btn_ubah);
            this.groupBox1.Controls.Add(this.btn_simpan);
            this.groupBox1.Controls.Add(this.lbl_nopasien);
            this.groupBox1.Controls.Add(this.tb_alamatpasien);
            this.groupBox1.Controls.Add(this.lbl_namapasien);
            this.groupBox1.Controls.Add(this.tb_namapasien);
            this.groupBox1.Controls.Add(this.lbl_alamatpasien);
            this.groupBox1.Controls.Add(this.tb_nopasien);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(292, 156);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(95, 36);
            this.btn_hapus.TabIndex = 7;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Location = new System.Drawing.Point(191, 156);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(95, 36);
            this.btn_ubah.TabIndex = 6;
            this.btn_ubah.Text = "UBAH";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(90, 156);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(95, 36);
            this.btn_simpan.TabIndex = 5;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // lbl_nopasien
            // 
            this.lbl_nopasien.AutoSize = true;
            this.lbl_nopasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nopasien.Location = new System.Drawing.Point(6, 18);
            this.lbl_nopasien.Name = "lbl_nopasien";
            this.lbl_nopasien.Size = new System.Drawing.Size(130, 24);
            this.lbl_nopasien.TabIndex = 0;
            this.lbl_nopasien.Text = "Nomor Pasien";
            this.lbl_nopasien.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_alamatpasien
            // 
            this.tb_alamatpasien.Location = new System.Drawing.Point(141, 109);
            this.tb_alamatpasien.Name = "tb_alamatpasien";
            this.tb_alamatpasien.Size = new System.Drawing.Size(335, 22);
            this.tb_alamatpasien.TabIndex = 4;
            // 
            // lbl_namapasien
            // 
            this.lbl_namapasien.AutoSize = true;
            this.lbl_namapasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namapasien.Location = new System.Drawing.Point(6, 61);
            this.lbl_namapasien.Name = "lbl_namapasien";
            this.lbl_namapasien.Size = new System.Drawing.Size(122, 24);
            this.lbl_namapasien.TabIndex = 1;
            this.lbl_namapasien.Text = "Nama Pasien";
            // 
            // tb_namapasien
            // 
            this.tb_namapasien.Location = new System.Drawing.Point(142, 63);
            this.tb_namapasien.Name = "tb_namapasien";
            this.tb_namapasien.Size = new System.Drawing.Size(334, 22);
            this.tb_namapasien.TabIndex = 4;
            // 
            // lbl_alamatpasien
            // 
            this.lbl_alamatpasien.AutoSize = true;
            this.lbl_alamatpasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alamatpasien.Location = new System.Drawing.Point(6, 107);
            this.lbl_alamatpasien.Name = "lbl_alamatpasien";
            this.lbl_alamatpasien.Size = new System.Drawing.Size(129, 24);
            this.lbl_alamatpasien.TabIndex = 2;
            this.lbl_alamatpasien.Text = "Alamat Pasien";
            // 
            // tb_nopasien
            // 
            this.tb_nopasien.Location = new System.Drawing.Point(142, 20);
            this.tb_nopasien.Name = "tb_nopasien";
            this.tb_nopasien.Size = new System.Drawing.Size(334, 22);
            this.tb_nopasien.TabIndex = 3;
            // 
            // lbl_datapasien
            // 
            this.lbl_datapasien.AutoSize = true;
            this.lbl_datapasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datapasien.Location = new System.Drawing.Point(15, 9);
            this.lbl_datapasien.Name = "lbl_datapasien";
            this.lbl_datapasien.Size = new System.Drawing.Size(109, 24);
            this.lbl_datapasien.TabIndex = 1;
            this.lbl_datapasien.Text = "Data Pasien";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListRiwayat);
            this.groupBox3.Location = new System.Drawing.Point(7, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(947, 156);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Riwayat Input";
            // 
            // ListRiwayat
            // 
            this.ListRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListRiwayat.Location = new System.Drawing.Point(10, 22);
            this.ListRiwayat.Name = "ListRiwayat";
            this.ListRiwayat.RowTemplate.Height = 24;
            this.ListRiwayat.Size = new System.Drawing.Size(928, 128);
            this.ListRiwayat.TabIndex = 0;
            // 
            // FPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 440);
            this.Controls.Add(this.lbl_datapasien);
            this.Controls.Add(this.panel1);
            this.Name = "FPasien";
            this.Text = "FPasien";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListPasien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nopasien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_namapasien;
        private System.Windows.Forms.Label lbl_alamatpasien;
        private System.Windows.Forms.Label lbl_datapasien;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_cari;
        private System.Windows.Forms.TextBox tb_cari;
        private System.Windows.Forms.DataGridView ListPasien;
        public System.Windows.Forms.TextBox tb_alamatpasien;
        public System.Windows.Forms.TextBox tb_namapasien;
        public System.Windows.Forms.TextBox tb_nopasien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ListRiwayat;
    }
}