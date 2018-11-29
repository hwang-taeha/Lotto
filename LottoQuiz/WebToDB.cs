using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace LottoQuiz
{
    class WebToDB
    {
        public static List<WebToDB> dataLst = new List<WebToDB>();
        //public static int[] games = new int[833];
        int drwNo, no1, no2, no3, no4, no5, no6, bonusNo;
        #region 프로퍼티
        public int DrwNo
        {
            get { return drwNo; }
            set { drwNo = value; }
        }
        public int No1
        {
            get { return no1; }
            set { no1 = value; }
        }
        public int No2
        {
            get { return no2; }
            set { no2 = value; }
        }
        public int No3
        {
            get { return no3; }
            set { no3 = value; }
        }
        public int No4
        {
            get { return no4; }
            set { no4 = value; }
        }
        public int No5
        {
            get { return no5; }
            set { no5 = value; }
        }
        public int No6
        {
            get { return no6; }
            set { no6 = value; }
        }
        public int BonusNo
        {
            get { return bonusNo; }
            set { bonusNo = value; }
        } 
        #endregion
        public WebToDB(int drwNo, int no1, int no2, int no3, int no4, int no5, int no6, int bonusNo)
        {
            this.drwNo = drwNo;
            this.no1 = no1;
            this.no2 = no2;
            this.no3 = no3;
            this.no4 = no4;
            this.no5 = no5;
            this.no6 = no6;
            this.bonusNo = bonusNo;
        }

        public WebToDB()
        {
            
        }
    }
}
