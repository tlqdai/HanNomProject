using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Threading;
using DevExpress.XtraWaitForm;

namespace HanNomSoft
{
    public partial class frmMain : Form
    {
        private Modules.ucDict ucDict;
        public frmMain()
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
                InitializeComponent();
                ucDict = new Modules.ucDict();
                Thread.Sleep(888);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void btnLookUpWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                ucDict.Size = pnlMain.Size;
                pnlMain.Controls.Add(ucDict);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void chkThieuChuu_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDict.ThieuChuu = chkThieuChuu.Checked;
            ucDict.loadMeaning();
        }

        private void chkTranVanChanh_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDict.TranVanChanh = chkTranVanChanh.Checked;
            ucDict.loadMeaning();
        }

        private void pnlMain_SizeChanged(object sender, EventArgs e)
        {
            ucDict.Size = pnlMain.Size;
        }
    }
}
