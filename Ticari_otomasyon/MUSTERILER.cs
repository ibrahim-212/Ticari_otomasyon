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

namespace Ticari_otomasyon
{
    public partial class MUSTERILER : Form
    {
        public MUSTERILER()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
     void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_ILLER",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
                {
                CmbIL.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void MUSTERILER_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();

        }

        private void CmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER Where SEHIR=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbIL.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbILCE.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void SbtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select ID From TBL_ILCELER where ILCE = @p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CmbILCE.SelectedItem);
            SqlDataReader dr = komut2.ExecuteReader();
            dr.Read();
            SqlCommand komut = new SqlCommand(" insert into TBL_MUSTERILER VALUES(@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", MskTel1.Text);
            komut.Parameters.AddWithValue("@p5", MskTel2.Text);
            komut.Parameters.AddWithValue("@p6", MskTc.Text);
            komut.Parameters.AddWithValue("@p7", TxtMail.Text);
            komut.Parameters.AddWithValue("@p8", dr[0].ToString());
            komut.Parameters.AddWithValue("@p9", TxtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p10", RtxtAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Eklendi");
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
           
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("SİLME İŞLEMİNİ Onaylıyor musunuz_?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("Delete from TBL_MUSTERILER where ID =@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", TxtId.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi");
                bgl.baglanti().Close();
                listele();
            }
            

            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr!=null)
            {
                SqlCommand komut = new SqlCommand("Select ILCE,(Select SEHIR From TBL_ILLER where ID=t.SEHIR) From TBL_ILCELER t  where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dr[7]);
                SqlDataReader ilce = komut.ExecuteReader();
                if(ilce.Read())
                {
                    TxtId.Text = dr["ID"].ToString();
                    TxtAd.Text = dr["AD"].ToString();
                    TxtSoyad.Text = dr["SOYAD"].ToString();
                    MskTel1.Text = dr["TELEFON"].ToString();
                    MskTel2.Text = dr["TELEFON2"].ToString();
                    MskTc.Text = dr["TC"].ToString();
                    TxtMail.Text = dr["MAIL"].ToString();
                    CmbIL.Text = ilce[1].ToString();
                    CmbILCE.Text = ilce[0].ToString();
                    TxtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
                    RtxtAdres.Text = dr["ADRES"].ToString();



                }

               
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select ID From TBL_ILCELER where ILCE = @ilce", bgl.baglanti());
            komut2.Parameters.AddWithValue("@ilce", CmbILCE.SelectedItem);
            SqlDataReader dr = komut2.ExecuteReader();
            dr.Read();

            SqlCommand guncelle = new SqlCommand("update TBL_MUSTERILER Set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,ILCE=@p7,ADRES=@p8,VERGIDAIRE=@p9  where ID=@p10", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", MskTel1.Text);
            guncelle.Parameters.AddWithValue("@p4", MskTel2.Text);
            guncelle.Parameters.AddWithValue("@p5", MskTc.Text);
            guncelle.Parameters.AddWithValue("@p6", TxtMail.Text);
            guncelle.Parameters.AddWithValue("@p7", dr[0]);
            guncelle.Parameters.AddWithValue("@p8", RtxtAdres.Text);
            guncelle.Parameters.AddWithValue("@p9", TxtVergiDairesi.Text);
            guncelle.Parameters.AddWithValue("@p10", TxtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncelleştirildi");
            listele();
        }
    }
}
