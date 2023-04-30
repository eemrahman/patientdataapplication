using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UAS_Muhammad_Rahman.GUI
{
    public partial class FPasien : Form
    {
        public FPasien()
        {
            InitializeComponent();
            BERSIH();
            refresh_tabel();
            refresh_riwayat();
        }


        Kelas.Koneksi konn = new Kelas.Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        void BERSIH()
        {
            tb_nopasien.Clear();
            tb_namapasien.Clear();
            tb_alamatpasien.Clear();
            tb_cari.Clear();
        }

        void ATUR_TOMBOL(Boolean status)
        {
            btn_simpan.Enabled = status;
            btn_hapus.Enabled = status;
            btn_ubah.Enabled = status;
        }

        void refresh_riwayat()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_history", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                ListRiwayat.DataSource = ds;
                da.Fill(ds, "tbl_history");
                ListRiwayat.DataMember = "tbl_history";
                ListRiwayat.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        void refresh_tabel()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_pasien", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                ListPasien.DataSource = ds;
                da.Fill(ds, "tbl_pasien");
                ListPasien.DataMember = "tbl_pasien";
                ListPasien.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tb_cari_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("EXECUTE SP_Cari '" + tb_cari.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_pasien");
            ListPasien.DataSource = ds;
            ListPasien.DataMember = "tbl_pasien";
            ListPasien.Refresh();
            conn.Close();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (tb_nopasien.Text.Trim() == "" || tb_namapasien.Text.Trim() == "" || tb_alamatpasien.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data", "warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("Execute SP_Simpan '" + tb_nopasien.Text + "','" + tb_namapasien.Text + "','" + tb_alamatpasien.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil ditambahkan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BERSIH();
                    refresh_tabel();
                    refresh_riwayat();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (tb_nopasien.Text.Trim() == "" || tb_namapasien.Text.Trim() == "" || tb_alamatpasien.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data", "warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("execute sp_ubah '" + tb_nopasien.Text + "','" + tb_namapasien.Text + "','" + tb_alamatpasien.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil di Ubah", "INFORMASI",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BERSIH();
                    refresh_tabel();
                    refresh_riwayat();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data?",
                "Konfirmasi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                conn.Open();
                cmd = new SqlCommand("execute SP_Hapus '" + tb_nopasien.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data barang berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BERSIH();
                refresh_tabel();
                refresh_riwayat();
            }
        }

        private void ListPasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListPasien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.ListPasien.Rows[e.RowIndex];
                tb_nopasien.Text = row.Cells["NoPasien"].Value.ToString();
                tb_namapasien.Text = row.Cells["NamaPasien"].Value.ToString();
                tb_alamatpasien.Text = row.Cells["AlamatPasien"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btn_riwayat_Click(object sender, EventArgs e)
        {

        }
    }
    }
