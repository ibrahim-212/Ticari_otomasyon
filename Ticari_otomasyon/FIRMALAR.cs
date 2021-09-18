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
    public partial class FIRMALAR : Form
    {
        public FIRMALAR()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        MUSTERILER musteri;
        void firmalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *  from TBL_FIRMALAR",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource= dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIL.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void FIRMALAR_Load(object sender, EventArgs e)
        {
            firmalistesi();

            sehirlistesi();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                SqlCommand komut = new SqlCommand("Select ILCE,(Select SEHIR From TBL_ILLER where ID=t.SEHIR) From TBL_ILCELER t  where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dr[12]);
                SqlDataReader ilce = komut.ExecuteReader();
                if (ilce.Read())
                {
                    TxtId.Text = dr[0].ToString();
                    TxtAd.Text = dr[1].ToString();
                    TxtYetkiliAd.Text = dr[3].ToString();
                    TxtYetkiliSoyad.Text = dr[4].ToString();
                    TxtSektor.Text = dr[6].ToString();
                    TxtYGörev.Text = dr[2].ToString();
                    MskTel1.Text = dr[7].ToString();
                    MskTel2.Text = dr[8].ToString();
                    MskTel3.Text = dr[9].ToString();
                    MskTc.Text = dr[5].ToString();
                    MskFax.Text = dr[11].ToString();
                    TxtMail.Text = dr[10].ToString();
                    CmbIL.Text = ilce[1].ToString();
                    CmbILCE.Text = ilce[0].ToString();
                    TxtVergi.Text = dr[13].ToString();
                    RchtAdres.Text = dr[14].ToString();
                    TxtOzelKod1.Text = dr[15].ToString();
                    TxtOzelKod2.Text = dr[16].ToString();
                    TxtOzelKod3.Text = dr[17].ToString();






                }


            }
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select ID From TBL_ILCELER where ILCE = @p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CmbILCE.SelectedItem);
            SqlDataReader dr = komut2.ExecuteReader();
            dr.Read();
            SqlCommand komut = new SqlCommand(" insert into TBL_FIRMALAR VALUES(@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtYGörev.Text);
            komut.Parameters.AddWithValue("@p4", TxtYetkiliAd.Text);
            komut.Parameters.AddWithValue("@p5", TxtYetkiliSoyad.Text);
            komut.Parameters.AddWithValue("@p6", MskTc.Text);
            komut.Parameters.AddWithValue("@p7", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p8", MskTel1.Text);
            komut.Parameters.AddWithValue("@p9", MskTel2.Text);
            komut.Parameters.AddWithValue("@p10", MskTel3.Text);
            komut.Parameters.AddWithValue("@p11", TxtMail.Text);
            komut.Parameters.AddWithValue("@p12", MskFax.Text);
            komut.Parameters.AddWithValue("@p13",dr[0].ToString());
            komut.Parameters.AddWithValue("@p14", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p15", RchtAdres.Text);
            komut.Parameters.AddWithValue("@p16", TxtOzelKod1.Text);
            komut.Parameters.AddWithValue("@p17", TxtOzelKod2.Text);
            komut.Parameters.AddWithValue("@p18", TxtOzelKod3.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Eklendi");
            firmalistesi();
        }

        private void CmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER Where SEHIR=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbIL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbILCE.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }
    }
}
