namespace HanNomSoft
{
    partial class frmMain
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
            this.rbcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLookUpWord = new DevExpress.XtraBars.BarButtonItem();
            this.chkThieuChuu = new DevExpress.XtraBars.BarCheckItem();
            this.chkTranVanChanh = new DevExpress.XtraBars.BarCheckItem();
            this.rbgDict = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpChiViet = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rbcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // rbcMain
            // 
            this.rbcMain.ExpandCollapseItem.Id = 0;
            this.rbcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbcMain.ExpandCollapseItem,
            this.btnLookUpWord,
            this.chkThieuChuu,
            this.chkTranVanChanh});
            this.rbcMain.Location = new System.Drawing.Point(0, 0);
            this.rbcMain.MaxItemId = 6;
            this.rbcMain.Name = "rbcMain";
            this.rbcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbgDict});
            this.rbcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.rbcMain.Size = new System.Drawing.Size(872, 142);
            // 
            // btnLookUpWord
            // 
            this.btnLookUpWord.Caption = "Tự điển";
            this.btnLookUpWord.Id = 1;
            this.btnLookUpWord.Name = "btnLookUpWord";
            this.btnLookUpWord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLookUpWord_ItemClick);
            // 
            // chkThieuChuu
            // 
            this.chkThieuChuu.Caption = "Thiều Chữu";
            this.chkThieuChuu.Checked = true;
            this.chkThieuChuu.Id = 4;
            this.chkThieuChuu.Name = "chkThieuChuu";
            this.chkThieuChuu.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkThieuChuu_CheckedChanged);
            // 
            // chkTranVanChanh
            // 
            this.chkTranVanChanh.Caption = "Trần Văn Chánh";
            this.chkTranVanChanh.Checked = true;
            this.chkTranVanChanh.Id = 5;
            this.chkTranVanChanh.Name = "chkTranVanChanh";
            this.chkTranVanChanh.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkTranVanChanh_CheckedChanged);
            // 
            // rbgDict
            // 
            this.rbgDict.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpChiViet});
            this.rbgDict.Name = "rbgDict";
            this.rbgDict.Text = "Tra từ";
            // 
            // rbpChiViet
            // 
            this.rbpChiViet.ItemLinks.Add(this.btnLookUpWord);
            this.rbpChiViet.ItemLinks.Add(this.chkThieuChuu);
            this.rbpChiViet.ItemLinks.Add(this.chkTranVanChanh);
            this.rbpChiViet.Name = "rbpChiViet";
            this.rbpChiViet.Text = "Hoa - Việt";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 142);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(872, 486);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.SizeChanged += new System.EventHandler(this.pnlMain_SizeChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 628);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.rbcMain);
            this.Name = "frmMain";
            this.Text = "Hán Nôm soft";
            ((System.ComponentModel.ISupportInitialize)(this.rbcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbcMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbgDict;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpChiViet;
        private DevExpress.XtraBars.BarButtonItem btnLookUpWord;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarCheckItem chkThieuChuu;
        private DevExpress.XtraBars.BarCheckItem chkTranVanChanh;
    }
}

