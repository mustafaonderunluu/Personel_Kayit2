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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MYPC\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglantı);
            SqlDataReader dr1=komut1.ExecuteReader();
            while (dr1.Read()) //dr1 komutu okuma yaptığı sürece (teker teker okuyor değerleri )
            {
                LblToplamPersonel.Text = dr1[0].ToString();


            }

            baglantı.Close();

            //evli personel Sayısı 
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerdDurum=1 ", baglantı);
            SqlDataReader dr2=komut2.ExecuteReader();
            while (dr2.Read()) { 
            
            LblEvliPersonel.Text = dr2[0].ToString();
            
            }
            baglantı.Close();
            //bekar personel sayısı 
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerdDurum=0 ", baglantı);
            SqlDataReader dr3=komut3.ExecuteReader();
            while (dr3.Read()) { 
            
            LblBekarPersonel.Text = dr3[0].ToString();
            
            
            }
            baglantı.Close();

            //Şehir Sayısı (Kaç farklı)
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel ", baglantı);
            SqlDataReader dr4 =komut4.ExecuteReader();
            while (dr4.Read()) {
                LblSehirSayısı.Text = dr4[0].ToString();
            
            
            
            
            }


            baglantı.Close();
            //Toplam Maaş 

            baglantı.Open ();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel ", baglantı);
            SqlDataReader dr5 =komut5.ExecuteReader();
            while (dr5.Read()) { 
            
            LblToplamMaas.Text = dr5[0].ToString();
            
            }

            baglantı.Close ();



            baglantı.Open () ;
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel ", baglantı);
            SqlDataReader dr6 =komut6.ExecuteReader();
            while (dr6.Read()) { 
            
            
            LblOrtMaas.Text = dr6[0].ToString();
                         
            }
            baglantı.Close();
        }   

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LblEvliPersonel_Click(object sender, EventArgs e)
        {

        }
    }
}
