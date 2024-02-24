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

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MYPC\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        
        void temizle() {

            txtid.Text = " ";
            txtad.Text = " ";
            txtsoyad.Text = " ";
            combosehir.Text = " ";
            maskmaas.Text = " ";
            maskmeslek.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtad.Focus();
        
        
        
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PersonelMeslek,PerdDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglantı);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", combosehir.Text);
            komut.Parameters.AddWithValue("@p4", maskmaas.Text);
            komut.Parameters.AddWithValue("@p5", maskmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text); 
            komut.ExecuteNonQuery();
            baglantı.Close();
            
            MessageBox.Show("Personel Eklendi ");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {


                label8.Text = "true";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) { 
            
            
            
            label8.Text= "false";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combosehir.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskmaas.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            maskmeslek.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True") { 
            
            radioButton1.Checked=true;
            
            }
            if (label8.Text == "False") { 
            
            
            radioButton2.Checked = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel where Perid=@k1", baglantı);
            komutsil.Parameters.AddWithValue("@k1", txtid.Text);
            komutsil.ExecuteNonQuery();

            baglantı.Close();

            MessageBox.Show("Kayıt Silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1, PerSoyad=@a2, PerSehir=@a3, PerMaas=@a4, PerdDurum=@a5, PersonelMeslek=@a6 where Perid=@a7", baglantı);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", combosehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", maskmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", maskmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtid.Text);

            komutguncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel Bilgi Güncellendi");
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr= new Frmİstatistik();
            fr.Show();
        }
    }
}
