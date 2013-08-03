using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HanNomSoft.Classes
{
    struct HNMeaning
    {
        private string mTranscription, mDetail;

        public string Transcription
        {
            get { return mTranscription; }
            set { mTranscription = value; }
        }

        public string Detail
        {
            get { return mDetail; }
            set { mDetail = value; }
        }

        public HNMeaning(string Transcription, string Detail)
        {
            mTranscription = Transcription;
            mDetail = Detail;
        }

        public string toHTML()
        {
            string str = "";
            str += "<b>" + mTranscription + "</b>";
            str += "</br>" + mDetail.Replace("||", "</br>");
            return str;
        }
    };

    class HNListMeaning
    {
        private List<HNMeaning> mListMeaning;

        public HNListMeaning()
        {
            mListMeaning = new List<HNMeaning>();
        }

        public HNListMeaning(HNMeaning meaning)
        {
            mListMeaning = new List<HNMeaning>();
            mListMeaning.Add(meaning);
        }

        public HNListMeaning(HNListMeaning listMeaning)
        {
            mListMeaning = listMeaning.mListMeaning;
        }

        public void add(HNMeaning meaning)
        {
            mListMeaning.Add(meaning);
        }

        public List<HNMeaning> getListMeaning()
        {
            return mListMeaning;
        }

        public int count()
        {
            return mListMeaning.Count;
        }

        public string toHTML()
        {
            string strResult = "";
            foreach (HNMeaning meaning in mListMeaning)
            {
                strResult += meaning.toHTML();
            }
            return strResult;
        }
    };

    class HNDictionary
    {
        private string mTitle;
        private Dictionary<string, HNListMeaning> mDict;

        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }

        public HNDictionary(string title)
        {
            mTitle = title;
            mDict = new Dictionary<string, HNListMeaning>();
        }

        public void addVocabulary(string vob, HNMeaning meaning)
        {
            mDict.Add(vob, new HNListMeaning(meaning));
        }

        public void addMeaning(string vob, HNMeaning meaning)
        {
            if (mDict.ContainsKey(vob))
            {
                mDict[vob].add(meaning);
            }
        }

        public Boolean checkVocabulary(string vob)
        {
            if ((mDict.ContainsKey(vob)) && (mDict[vob].count() > 0))
                return true;
            return false;
        }

        public List<string> getListVocabulary()
        {
            return (new List<string>(mDict.Keys));
        }
        
        public string meaning2HTML(string vob)
        {
            if (checkVocabulary(vob))
            {
                string strHTML = "<font color='red'><b>" + mTitle + "</b></font></br>";
                return (strHTML + mDict[vob].toHTML());
            }
            return "";
        }
    }
}
