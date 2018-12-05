using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//회차 넣을때 + 금액나와있는거 db에 같이 올리거나 리스트에 회차별로 저장시킨게 계속 남아있어야해


namespace LottoQuiz
{
    public partial class FrmKwon : Form
    {
        List<WebToDB> dataLst = new List<WebToDB>();
        List<LottoData> lst = new List<LottoData>();

        int no1, no2, no3, no4, no5, no6, bonusno, drwno;
        string rank, total, won, gamecount;

        public FrmKwon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 836; i++)
            {
                WebRequest request = WebRequest.Create("http://nlotto.co.kr/gameResult.do?method=byWin&drwNo=" + i);
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(stream);
                HtmlNode root = doc.DocumentNode;

                drwno += 1;

                no1 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[1].InnerText);
                no2 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[3].InnerText);
                no3 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[5].InnerText);
                no4 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[7].InnerText);
                no5 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[9].InnerText);
                no6 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[11].InnerText);
                bonusno = int.Parse(root.SelectNodes("//p")[3].ChildNodes[0].InnerText);

                //foreach (var item in root.SelectNodes("//p"))
                //{
                //    if (item.GetAttributeValue("class", "") == "number")
                //    {
                //        no1 = int.Parse(item.ChildNodes[1].GetAttributeValue("alt", ""));
                //        no2 = int.Parse(item.ChildNodes[3].GetAttributeValue("alt", ""));
                //        no3 = int.Parse(item.ChildNodes[5].GetAttributeValue("alt", ""));
                //        no4 = int.Parse(item.ChildNodes[7].GetAttributeValue("alt", ""));
                //        no5 = int.Parse(item.ChildNodes[9].GetAttributeValue("alt", ""));
                //        no6 = int.Parse(item.ChildNodes[11].GetAttributeValue("alt", ""));
                //        bonusno = int.Parse(item.ChildNodes[15].FirstChild.GetAttributeValue("alt", ""));
                //        break;
                //    }
                //}
                dataLst.Add(new WebToDB(drwno, no1, no2, no3, no4, no5, no6, bonusno));

                string c = "Data Source = 192.168.0.2; Initial Catalog = Lotto_DB; User ID = LottoClient; Password = 1234";
                SqlConnection con = new SqlConnection(c);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PROP_INSERT_FORLOTTO";
                con.Open();

                cmd.Parameters.AddWithValue("@DRWNO", drwno).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@NO1", no1).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@NO2", no2).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@NO3", no3).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@NO4", no4).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@NO5", no5).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@NO6", no6).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@BONUSNO", bonusno).Direction = ParameterDirection.Input;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    MessageBox.Show("오류");
                }

                con.Close();
            }
            MessageBox.Show("insert 완료");
        } // 웹 > DB 파싱

        private void btnView_Click(object sender, EventArgs e)
        {
            drwno = 0;
            dataGridView1.DataSource = "";
            dataGridView1.Show();
            dataLst.Clear();

            if (txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("오류");
            }
            else if (int.Parse(txt1.Text) > int.Parse(txt2.Text))
            {
                string temp = txt1.Text;
                txt1.Text = txt2.Text;
                txt2.Text = temp;
            }
            else
            {
                for (int i = int.Parse(txt1.Text); i <= int.Parse(txt2.Text); i++)
                {
                    WebRequest request = WebRequest.Create("https://www.dhlottery.co.kr/gameResult.do?method=byWin&drwNo=" + i);
                    WebResponse response = request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.Load(stream);
                    HtmlNode root = doc.DocumentNode;
                    drwno += 1;
                    no1 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[1].InnerText);
                    no2 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[3].InnerText);
                    no3 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[5].InnerText);
                    no4 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[7].InnerText);
                    no5 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[9].InnerText);
                    no6 = int.Parse(root.SelectNodes("//p")[2].ChildNodes[11].InnerText);
                    bonusno = int.Parse(root.SelectNodes("//p")[3].ChildNodes[0].InnerText);

                    dataLst.Add(new WebToDB(drwno, no1, no2, no3, no4, no5, no6, bonusno));
                }

                dataGridView1.DataSource = dataLst;
                dataGridView1.Columns["drwno"].HeaderText = "회차";
                dataGridView1.Columns["no1"].HeaderText = "첫번째";
                dataGridView1.Columns["no2"].HeaderText = "두번째";
                dataGridView1.Columns["no3"].HeaderText = "세번째";
                dataGridView1.Columns["no4"].HeaderText = "네번째";
                dataGridView1.Columns["no5"].HeaderText = "다섯번째";
                dataGridView1.Columns["no6"].HeaderText = "여섯번째";
                dataGridView1.Columns["bonusno"].HeaderText = "보너스번호";
                dataGridView1.Show();
                MessageBox.Show("완료");
            }     
        } // 회차 출력

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            dataGridView1.Show();

            if (textBox1.Text == "") // @"[0-9]"
            {
                MessageBox.Show("공백입니다");
            }
            else
            {
                dataGridView1.Show();

                lst.Clear();

                WebRequest request = WebRequest.Create("https://www.dhlottery.co.kr/gameResult.do?method=byWin&drwNo=" + textBox1.Text);
                WebResponse response = request.GetResponse();

                HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
                html.Load(response.GetResponseStream());
                HtmlNode hnc = html.DocumentNode;
                HtmlNodeCollection col = new HtmlNodeCollection(hnc);

                rank = hnc.SelectNodes("//td")[0].InnerText;
                total = hnc.SelectNodes("//td")[1].InnerText;
                gamecount = hnc.SelectNodes("//td")[2].InnerText;
                won = hnc.SelectNodes("//td")[3].InnerText;
                lst.Add(new LottoData(rank, total, gamecount, won));

                rank = hnc.SelectNodes("//td")[6].InnerText;
                total = hnc.SelectNodes("//td")[7].InnerText;
                gamecount = hnc.SelectNodes("//td")[8].InnerText;
                won = hnc.SelectNodes("//td")[9].InnerText;
                lst.Add(new LottoData(rank, total, gamecount, won));

                rank = hnc.SelectNodes("//td")[11].InnerText;
                total = hnc.SelectNodes("//td")[12].InnerText;
                gamecount = hnc.SelectNodes("//td")[13].InnerText;
                won = hnc.SelectNodes("//td")[14].InnerText;
                lst.Add(new LottoData(rank, total, gamecount, won));

                rank = hnc.SelectNodes("//td")[16].InnerText;
                total = hnc.SelectNodes("//td")[17].InnerText;
                gamecount = hnc.SelectNodes("//td")[18].InnerText;
                won = hnc.SelectNodes("//td")[19].InnerText;
                lst.Add(new LottoData(rank, total, gamecount, won));

                rank = hnc.SelectNodes("//td")[21].InnerText;
                total = hnc.SelectNodes("//td")[22].InnerText;
                gamecount = hnc.SelectNodes("//td")[23].InnerText;
                won = hnc.SelectNodes("//td")[24].InnerText;
                lst.Add(new LottoData(rank, total, gamecount, won));

                dataGridView1.DataSource = lst;
                dataGridView1.Columns["rank"].HeaderText = "순위";
                dataGridView1.Columns["total"].HeaderText = "등위별 총 당첨금액";
                dataGridView1.Columns["gamecount"].HeaderText = "당첨게임 수";
                dataGridView1.Columns["won"].HeaderText = "1게임당 당첨금액";
                dataGridView1.Show();
                MessageBox.Show("완료");
            }
        } // 그리드 뷰 보기
    }
}