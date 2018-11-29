using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace LottoQuiz
{
    public partial class Form1 : Form
    {
        int[] a = new int[3];
        Point p = new Point(20, 10);
        Size s = new Size(800, 25);
        //ProgressBar progressBar = new ProgressBar();


        private void 이전로또당첨확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Sjm fs = new Form1_Sjm();
            fs.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LottoRecommand lottoRecommand = new LottoRecommand();
            lottoRecommand.Show();
        }

        private void 각번호를뽑은순서ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrder frmOrder = new FrmOrder();
            frmOrder.Show();
        }

        private void 번호별당첨횟수ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNoStat frmNoStat = new FrmNoStat();
            frmNoStat.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlServerConnect sqlServer = SqlServerConnect.CreateSQL();
            
            string lottoServerStr = ConfigurationManager.ConnectionStrings["Lotto"].ConnectionString;
            sqlServer.ServerOpen(lottoServerStr);
            SqlCommand com = new SqlCommand();
            com.Connection = sqlServer.ServerOpen(lottoServerStr);
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SelectDB";

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                WebToDB.dataLst.Add(new WebToDB(Int32.Parse(dr["DRWNO"].ToString()), Int32.Parse(dr["NO1"].ToString()), Int32.Parse(dr["NO2"].ToString()), Int32.Parse(dr["NO3"].ToString()),
                Int32.Parse(dr["NO4"].ToString()), Int32.Parse(dr["NO5"].ToString()), Int32.Parse(dr["NO6"].ToString()), Int32.Parse(dr["BONUSNO"].ToString())));
            }
            dr.Close();
            sqlServer.ServerClose();
            
                //string constr = ConfigurationManager.ConnectionStrings["Lotto"].ConnectionString;
                //SqlConnection con = new SqlConnection(constr);
                //SqlCommand cmd = new SqlCommand();

                //try
                //{
                //    con.Open();
                //    MessageBox.Show("성공");
                //    cmd.Connection = con;
                //    cmd.CommandType = CommandType.Text;
                //    cmd.CommandText = "select*from forlotto";

                //    var dr = cmd.ExecuteReader();
                //    while (dr.Read())
                //    {
                //        MessageBox.Show(dr["NO1"].ToString());
                //    }
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("실패");
                //}
                //con.Close();

            }

            private void button2_Click(object sender, EventArgs e)
        {
            FrmNoStat frmNoStat = new FrmNoStat();
            frmNoStat.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void 패턴분석ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmPattern().Show();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{            
        //    for (int i = 1; i < 5; i++)
        //    {
        //        WebRequest request = WebRequest.Create("http://nlotto.co.kr/gameResult.do?method=byWin&drwNo=" + i);
        //        WebResponse response = request.GetResponse();
        //        Stream stream = response.GetResponseStream();
        //        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        //        doc.Load(stream);
        //        HtmlNode root = doc.DocumentNode;
        //        foreach (var item in root.SelectNodes("//p"))
        //        {
        //            if (item.GetAttributeValue("class", "") == "number")
        //            {
        //                no1 = int.Parse(item.ChildNodes[1].GetAttributeValue("alt", ""));
        //                no2 = int.Parse(item.ChildNodes[3].GetAttributeValue("alt", ""));
        //                no3 = int.Parse(item.ChildNodes[5].GetAttributeValue("alt", ""));
        //                no4 = int.Parse(item.ChildNodes[7].GetAttributeValue("alt", ""));
        //                no5 = int.Parse(item.ChildNodes[9].GetAttributeValue("alt", ""));
        //                no6 = int.Parse(item.ChildNodes[11].GetAttributeValue("alt", ""));
        //                bonusNo = int.Parse(item.ChildNodes[15].FirstChild.GetAttributeValue("alt", ""));
        //                break;                        
        //            }
        //        }
        //        WebToDB.dataLst.Add(new WebToDB(i, no1, no2, no3, no4, no5, no6, bonusNo));
        //    }
        //}
    }
}