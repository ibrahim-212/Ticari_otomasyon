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
        void firmalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *  from TBL_FIRMALAR",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource= dt;
        }
        private void FIRMALAR_Load(object sender, EventArgs e)
        {
            firmalistesi();

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
    }
}
