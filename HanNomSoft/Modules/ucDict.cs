using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;

using HanNomSoft.Classes;

namespace HanNomSoft.Modules
{
    public partial class ucDict : UserControl
    {
        private Boolean bThieuChuu;
        private Boolean bTranVanChanh;
        private HNDictionary dictThieuChuu = new HNDictionary("Thieu Chuu");
        private HNDictionary dictTranVanChanh = new HNDictionary("Tran Van Chanh");

        public Boolean ThieuChuu
        {
            get { return bThieuChuu; }
            set { bThieuChuu = value; }
        }

        public Boolean TranVanChanh
        {
            get { return bTranVanChanh; }
            set { bTranVanChanh = value; }
        }

        public ucDict()
        {
            InitializeComponent();
            initData();
        }       

        private void initData()
        {
            bThieuChuu = true;
            bTranVanChanh = true;

            loadDictionary(dictThieuChuu, "thieuchuu.dict");
            loadDictionary(dictTranVanChanh, "tranvanchanh.dict");

            lbxVocabulary.DataSource = dictThieuChuu.getListVocabulary().Concat(dictTranVanChanh.getListVocabulary()).Distinct().ToList();
        }

        private void loadDictionary(HNDictionary dict, string fName)
        {
            Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("HanNomSoft.Resources.Corpus." + fName);
            StreamReader reader = new StreamReader(stream);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('\t');
                if (!dict.checkVocabulary(parts[1]))
                    dict.addVocabulary(parts[1], new HNMeaning(parts[2], parts[3]));
                else
                    dict.addMeaning(parts[1], new HNMeaning(parts[2], parts[3]));
            }
            reader.Close();
        }

        private void lbxVocabulary_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVocabulary.Text = lbxVocabulary.SelectedValue.ToString();
            loadMeaning();
        }

        public void loadMeaning()
        {
            string currVob = lbxVocabulary.SelectedItem.ToString();
            string strContent = "";
            if (this.bThieuChuu && dictThieuChuu.checkVocabulary(currVob))
                strContent += dictThieuChuu.meaning2HTML(currVob);

            strContent += "</br></br>";

            if (this.bTranVanChanh && dictTranVanChanh.checkVocabulary(currVob))
                strContent += dictTranVanChanh.meaning2HTML(currVob);

            reditMeaning.Document.HtmlText = strContent;
        }

        private void txtVocabulary_TextChanged(object sender, EventArgs e)
        {
            lbxVocabulary.SelectedValue = txtVocabulary.Text;
        }
    }
}