namespace Ticari_otomasyon
{
    partial class ÜRÜNLER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜRÜNLER));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.MskYil = new System.Windows.Forms.MaskedTextBox();
            this.SbtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RtxtDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSatFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAlFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.NudAdet = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtModel = new DevExpress.XtraEditors.TextEdit();
            this.TxtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnGüncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.MskYil);
            this.groupControl1.Controls.Add(this.SbtnKaydet);
            this.groupControl1.Controls.Add(this.RtxtDetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtSatFiyat);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.TxtAlFiyat);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.NudAdet);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtModel);
            this.groupControl1.Controls.Add(this.TxtMarka);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(913, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(220, 487);
            this.groupControl1.TabIndex = 0;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(72, 435);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(143, 39);
            this.BtnGüncelle.TabIndex = 22;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(72, 390);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(143, 39);
            this.BtnSil.TabIndex = 21;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // MskYil
            // 
            this.MskYil.Location = new System.Drawing.Point(72, 133);
            this.MskYil.Mask = "0000";
            this.MskYil.Name = "MskYil";
            this.MskYil.Size = new System.Drawing.Size(143, 21);
            this.MskYil.TabIndex = 20;
            this.MskYil.ValidatingType = typeof(int);
            // 
            // SbtnKaydet
            // 
            this.SbtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SbtnKaydet.ImageOptions.Image")));
            this.SbtnKaydet.Location = new System.Drawing.Point(72, 345);
            this.SbtnKaydet.Name = "SbtnKaydet";
            this.SbtnKaydet.Size = new System.Drawing.Size(143, 39);
            this.SbtnKaydet.TabIndex = 19;
            this.SbtnKaydet.Text = "Kaydet";
            this.SbtnKaydet.Click += new System.EventHandler(this.SbtnKaydet_Click);
            // 
            // RtxtDetay
            // 
            this.RtxtDetay.Location = new System.Drawing.Point(72, 243);
            this.RtxtDetay.Name = "RtxtDetay";
            this.RtxtDetay.Size = new System.Drawing.Size(143, 96);
            this.RtxtDetay.TabIndex = 18;
            this.RtxtDetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 246);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Detay:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(2, 220);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Satış Fiyat:";
            // 
            // TxtSatFiyat
            // 
            this.TxtSatFiyat.Location = new System.Drawing.Point(72, 213);
            this.TxtSatFiyat.Name = "TxtSatFiyat";
            this.TxtSatFiyat.Size = new System.Drawing.Size(143, 20);
            this.TxtSatFiyat.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 168);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Adet:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 194);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Alış Fiyat :";
            // 
            // TxtAlFiyat
            // 
            this.TxtAlFiyat.Location = new System.Drawing.Point(72, 187);
            this.TxtAlFiyat.Name = "TxtAlFiyat";
            this.TxtAlFiyat.Size = new System.Drawing.Size(143, 20);
            this.TxtAlFiyat.TabIndex = 11;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(43, 141);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(14, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Yıl:";
            // 
            // NudAdet
            // 
            this.NudAdet.Location = new System.Drawing.Point(72, 160);
            this.NudAdet.Name = "NudAdet";
            this.NudAdet.Size = new System.Drawing.Size(143, 21);
            this.NudAdet.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Model:";
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(72, 108);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(143, 20);
            this.TxtModel.TabIndex = 6;
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(72, 82);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(143, 20);
            this.TxtMarka.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Marka:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(72, 56);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(143, 20);
            this.TxtAd.TabIndex = 2;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(72, 30);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(143, 20);
            this.TxtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(881, 487);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // ÜRÜNLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 630);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "ÜRÜNLER";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.ÜRÜNLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtSatFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtAlFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.NumericUpDown NudAdet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtModel;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton SbtnKaydet;
        private System.Windows.Forms.RichTextBox RtxtDetay;
        private System.Windows.Forms.MaskedTextBox MskYil;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
    }
}