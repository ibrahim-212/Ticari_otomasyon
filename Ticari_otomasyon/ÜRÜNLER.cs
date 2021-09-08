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
    public partial class ÜRÜNLER : Form
    {
        public ÜRÜNLER()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
         void  listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void ÜRÜNLER_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void SbtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into TBL_URUNLER(AD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6",decimal.Parse((TxtAlFiyat.Text)));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((TxtSatFiyat.Text)));
            komut.Parameters.AddWithValue("@p8", RtxtDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();



        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from TBL_URUNLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi","Bilgi");
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["AD"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
            TxtModel.Text = dr["MODEL"].ToString();
            MskYil.Text = dr["YIL"].ToString();
            NudAdet.Value =int.Parse( dr["ADET"].ToString());
            TxtAlFiyat.Text = dr["ALISFIYAT"].ToString();
            TxtSatFiyat.Text = dr["SATISFIYAT"].ToString();
            RtxtDetay.Text = dr["DETAY"].ToString();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

           SqlCommand guncelle = new SqlCommand("Update TBL_URUNLER set AD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 where ID=@p9",bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", TxtMarka.Text);
            guncelle.Parameters.AddWithValue("@p3", TxtModel.Text);
            guncelle.Parameters.AddWithValue("@p4", MskYil.Text);
            guncelle.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            guncelle.Parameters.AddWithValue("@p6", decimal.Parse((TxtAlFiyat.Text)));
            guncelle.Parameters.AddWithValue("@p7", decimal.Parse((TxtSatFiyat.Text)));
            guncelle.Parameters.AddWithValue("@p8", RtxtDetay.Text);
            guncelle.Parameters.AddWithValue("@p9", TxtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi","BİLGİ");
            listele();
        }
    }
}
