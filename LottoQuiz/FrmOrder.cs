using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LottoQuiz
{    
    public partial class FrmOrder : Form
    {
        int count;
        List<Check> ck = new List<Check>();
        List<SectionCheck> schklst = new List<SectionCheck>();
        int[] balls = new int[45]; // 전체 공
        string[] oddOrEven = { "홀수", "짝수" };
        int[] number = new int[2];
        List<int[]> section = new List<int[]>();
        string[] sepSection = { "1~10", "11~20", "21~30", "31~40", "41~45" };
        int[] sectionNum = new int[5];
        //int odd;
        //int even;
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            // 홀짝 비율
            foreach (var item in WebToDB.dataLst)
            {
                balls[item.No1 - 1]++;
                balls[item.No2 - 1]++;
                balls[item.No3 - 1]++;
                balls[item.No4 - 1]++;
                balls[item.No5 - 1]++;
                balls[item.No6 - 1]++;
                balls[item.BonusNo - 1]++;
            }
            for (int i = 0; i < 45; i++)
            {
                if (i % 2 == 0) // 번호가 홀수
                {
                    number[0] += balls[i];
                }
                else // 번호가 짝수
                {
                    number[1] += balls[i];
                }
            }
            chart1.Series[0].Name = "홀수,짝수";
            chart1.Titles.Add("홀짝별 당첨 횟수");
            chart1.Series[0].Points.DataBindXY(oddOrEven, number);

            foreach (var item in WebToDB.dataLst)
            {
                int[] num = { item.No1, item.No2, item.No3, item.No4, item.No5, item.No6 };
                string odd = "";
                string even = "";                
                foreach (var check in num)
                {                    
                    if (check % 2 == 1)
                    {
                        odd += check + ", ";                        
                    }
                    if (check % 2 == 0)
                    {
                        even += check + ", ";                        
                    }                    
                }
                ck.Add(new Check(item.DrwNo, odd, even));                
            }
            foreach (var item in ck)
            {
                if (item.Odd.Length < 2)
                {
                    item.Even = item.Even.Remove(item.Even.Length - 2);
                }
                else if (item.Even.Length < 2)
                {
                    item.Odd = item.Odd.Remove(item.Odd.Length - 2);
                }
                else
                {
                    item.Odd = item.Odd.Remove(item.Odd.Length - 2);
                    item.Even = item.Even.Remove(item.Even.Length - 2);
                }
            }                        
            GridOddOrEven.DataSource = ck;
            GridOddOrEven.Columns[0].HeaderText = "회차";
            GridOddOrEven.Columns[1].HeaderText = "홀수";
            GridOddOrEven.Columns[2].HeaderText = "짝수";
            //GridOddOrEven.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GridOddOrEven.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GridOddOrEven.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
        }
        Point? previous = null;
        ToolTip myToolTip = new ToolTip();
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            Point nowPosition = e.Location;
            if (previous.HasValue && nowPosition == previous) // 마우스 움직임이 없을 때
            {
                return;
            }
            //myToolTip.RemoveAll();
            previous = nowPosition;
            HitTestResult hit = chart1.HitTest(nowPosition.X, nowPosition.Y, ChartElementType.DataPoint);
            //balls.Reverse();
            if (hit.ChartElementType == ChartElementType.DataPoint)
            {
                var hitOddOrEven = oddOrEven[hit.PointIndex];
                decimal hitNumber = number[hit.PointIndex];
                myToolTip.Show(hitOddOrEven + " 당첨 비율 : " + decimal.Round(hitNumber/(number[0]+number[1])*100) + "%", chart1, new Point(nowPosition.X + 10, nowPosition.Y + 15));
            }
        }
        private void StaticBySection()
        {
            schklst.Clear();
            gridSection.DataSource = null;
            try
            {
                count = (int)nmcSection.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("1부터 834주까지만 입력 해 주세요.");
            }
            for (int i = WebToDB.dataLst.Count - 1; i > WebToDB.dataLst.Count - count - 1; i--) 
            {
                int[] addNum = { WebToDB.dataLst[i].No1, WebToDB.dataLst[i].No2, WebToDB.dataLst[i].No3, WebToDB.dataLst[i].No4, WebToDB.dataLst[i].No5, WebToDB.dataLst[i].No6 };
                section.Add(addNum);
                string oneToTen = "";
                string eleToTwe = "";
                string twoToThi = "";
                string thiToFor = "";
                string etc = "";
                int drwNo = WebToDB.dataLst[i].DrwNo;
                foreach (int item in addNum)
                {
                    if (item > 0 && item < 11)
                    {
                        oneToTen += item + ", "; 
                    }
                    else if (item > 11 && item < 21)
                    {
                        eleToTwe += item + ", "; 
                    }
                    else if (item > 21 && item < 31)
                    {
                        twoToThi += item + ", ";
                    }
                    else if (item > 31 && item < 41)
                    {
                        thiToFor += item + ", ";
                    }
                    else
                    {
                        etc += item + ", ";
                    }                    
                }
                schklst.Add(new SectionCheck(drwNo, oneToTen, eleToTwe, twoToThi, thiToFor, etc));
            }
            foreach (var item in schklst)
            {

                if (item.OneToTen.Length > 2)
                {
                    item.OneToTen = item.OneToTen.Remove(item.OneToTen.Length - 2);
                }
                if (item.EleToTwe.Length > 2)
                {
                    item.EleToTwe = item.EleToTwe.Remove(item.EleToTwe.Length - 2);
                }
                if (item.TwoToThi.Length > 2)
                {
                    item.TwoToThi = item.TwoToThi.Remove(item.TwoToThi.Length - 2);
                }
                if (item.ThiToFor.Length > 2)
                {
                    item.ThiToFor = item.ThiToFor.Remove(item.ThiToFor.Length - 2);
                }                
                if (item.Etc.Length > 2)
                {
                    item.Etc = item.Etc.Remove(item.Etc.Length - 2);
                }
            }
            gridSection.DataSource = schklst;
            gridSection.Columns[0].HeaderText = "회차";
            gridSection.Columns[1].HeaderText = "41-45구간";
            gridSection.Columns[2].HeaderText = "31-40구간";
            gridSection.Columns[3].HeaderText = "21-30구간";
            gridSection.Columns[4].HeaderText = "11-20구간";
            gridSection.Columns[5].HeaderText = "1-10구간";            
        }
        private void ChartSection()
        {
            
            chartSection.Series[0].ChartType = SeriesChartType.Pie;
            for (int i = 0; i < 10; i++)
            {
                sectionNum[0] += balls[i];
            }
            for (int i = 10; i < 20; i++)
            {
                sectionNum[1] += balls[i];
            }
            for (int i = 20; i < 30; i++)
            {
                sectionNum[2] += balls[i];
            }
            for (int i = 30; i < 40; i++)
            {
                sectionNum[3] += balls[i];
            }
            for (int i = 40; i < 45; i++)
            {
                sectionNum[4] += balls[i];
            }
            chartSection.Series[0].Points.DataBindXY(sepSection, sectionNum);
            chartSection.Series[0].Name = "구간별 당첨 통계";
            chartSection.Titles.Clear();
            chartSection.Titles.Add("구간별 당첨 통계");
        }
        

        private void btnGridVisible_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            GridOddOrEven.Visible = false;
            gridSection.Visible = false;
            chartSection.Visible = false;
        }

        private void btnChartVisible_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            GridOddOrEven.Visible = true;
            gridSection.Visible = false;
            chartSection.Visible = false;
            myToolTip.RemoveAll();
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            ChartSection();
            myToolTip.RemoveAll();
            chart1.Visible = false;
            GridOddOrEven.Visible = false;
            gridSection.Visible = false;
            chartSection.Visible = true;
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            GridOddOrEven.Visible = false;
            gridSection.Visible = true;
            chartSection.Visible = false;
            StaticBySection();
            myToolTip.RemoveAll();
        }

        private void chartSection_MouseMove(object sender, MouseEventArgs e)
        {
            Point nowPosition = e.Location;
            if (previous.HasValue && nowPosition == previous) // 마우스 움직임이 없을 때
            {
                return;
            }
            //myToolTip.RemoveAll();
            previous = nowPosition;
            HitTestResult hit = chartSection.HitTest(nowPosition.X, nowPosition.Y, ChartElementType.DataPoint);
            //balls.Reverse();
            if (hit.ChartElementType == ChartElementType.DataPoint)
            {
                var sepSec = sepSection[hit.PointIndex];
                decimal secNum = sectionNum[hit.PointIndex];
                myToolTip.Show(sepSec + "구간 당첨 비율 : "+ decimal.Round(secNum / (sectionNum[0]+ sectionNum[1]+ sectionNum[2]+ sectionNum[3]+ sectionNum[4]) * 100) + "%", chartSection, new Point(nowPosition.X + 10, nowPosition.Y + 15));
            }
        }
    }
}
