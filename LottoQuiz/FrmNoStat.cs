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
    public partial class FrmNoStat : Form
    {        
        string[] reverseLNum;
        int[] reverseBalls;
        string[] lNum = new string[45];
        Point p = new Point(100, 10);
        Point pointForLbl = new Point(0, 10);
        Size s = new Size(800, 25);
        ProgressBar progressBar = new ProgressBar();
        Point? previous = null;
        ToolTip myToolTip = new ToolTip();
        #region 배열들
        int[] balls = new int[45]; // 전체 공
        int[] firstBall = new int[45]; // 1번째로 뽑은 공
        int[] secondBall = new int[45];// 2번째로 뽑은 공
        int[] thirdBall = new int[45];// 3번째로 뽑은 공
        int[] forthBall = new int[45];// 4번째로 뽑은 공
        int[] fifthBall = new int[45];// 5번째로 뽑은 공
        int[] sixthBall = new int[45];// 6번째로 뽑은 공
        int[] bonusBall = new int[45]; // 보너스 공으로 뽑은 공
        #endregion        

        public FrmNoStat()
        {
            InitializeComponent();
        }

        private void FrmNoStat_Load(object sender, EventArgs e)
        {
            chart1.Series[0].IsXValueIndexed = true;
            AxisScaleBreakStyle ax = new AxisScaleBreakStyle();
            //ax.CollapsibleSpaceThreshold = 10;
            
            chart1.ChartAreas[0].AxisX.ScaleBreakStyle = ax;
            chart1.Series[0].ChartType = SeriesChartType.Bar;
            //chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisX.Maximum = 0;
            //chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 46;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            //chart1.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            //chart1.Series[0];

            chart1.Series[0].Name = "당첨 횟수";
            chart1.Titles.Add("번호별 당첨 횟수");
            foreach (var item in WebToDB.dataLst)
            {
                balls[item.No1-1]++;
                balls[item.No2-1]++;
                balls[item.No3-1]++;
                balls[item.No4-1]++;
                balls[item.No5-1]++;
                balls[item.No6-1]++;
                balls[item.BonusNo-1]++;                             
            } // 리스트 내의 데이터를 배열로 옮겨옴.
            for (int i = 44; i >= 0; i--)
            {
                //Label lbl = new Label();
                //lbl.Text = i + 1 + "번 공 " + balls[i + 1] + "회 당첨";
                //lbl.Location = pointForLbl;
                //ProgressBar progressBar = new ProgressBar();
                //progressBar.Visible = true;                
                //progressBar.Location = p;
                //progressBar.Name = "progressBar" + i + 1;
                //progressBar.Size = new System.Drawing.Size(800, 25);
                //progressBar.Value = balls[i + 1];
                //Controls.Add(progressBar);
                //Controls.Add(lbl);
                //pointForLbl.Y += 30;
                //p.Y += 30;
                //chart1.Series[0].Points.AddXY(i+1+"번", balls[i]);
                lNum[i] = (i+1).ToString();                
                //chart1.Series[0].Points.Add(balls[i], i);
            }
            reverseBalls = balls.Reverse().ToArray();
            reverseLNum = lNum.Reverse().ToArray();
            chart1.Series[0].Points.DataBindXY(reverseLNum, reverseBalls);
            for (int i = 0; i < 45; i++)
            {
                if (i < 5)
                {
                    chart1.Series[0].Points[i].Color = Color.ForestGreen;
                }
                else if (i < 15)
                {
                    chart1.Series[0].Points[i].Color = Color.Gray;
                }
                else if (i < 25)
                {
                    chart1.Series[0].Points[i].Color = Color.OrangeRed;
                }
                else if (i < 35)
                {
                    chart1.Series[0].Points[i].Color = Color.BlueViolet;
                }
                else
                {
                    chart1.Series[0].Points[i].Color = Color.GreenYellow;
                }
            }
            Search(45);
        }
        
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {            
            Point nowPosition = e.Location;
            if (previous.HasValue && nowPosition == previous) // 마우스 움직임이 없을 때
            {
                return;
            }
            myToolTip.RemoveAll();
            previous = nowPosition;
            HitTestResult hit = chart1.HitTest(nowPosition.X, nowPosition.Y, ChartElementType.DataPoint);
            //balls.Reverse();
            if (hit.ChartElementType == ChartElementType.DataPoint)
            {
                var ballNum = reverseLNum[hit.PointIndex];
                var ptBalls = reverseBalls[hit.PointIndex];
                myToolTip.Show(ballNum + "번 공 당첨 횟수 : " + ptBalls, chart1, new Point(nowPosition.X + 10, nowPosition.Y + 15));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridNum.ClearSelection();
            gridNum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                gridNum.Rows[int.Parse(txtSearch.Text) - 1].Selected = true;
                gridNum.CurrentCell = gridNum.Rows[int.Parse(txtSearch.Text) - 1].Cells[0];
            }
            catch (Exception)
            {
                MessageBox.Show("1~45까지의 수 만 취급 합니다.");
            }
            txtSearch.Text = "";
        }

        void Search(int count)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("number"));
            dt.Columns.Add(new DataColumn("count"));
            for (int i = 0; i < count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["number"] = lNum[i];
                dr["count"] = balls[i];
                dt.Rows.Add(dr);
            }
            gridNum.DataSource = dt;
            gridNum.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridNum.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridNum.Columns[0].HeaderText = "번호";
            gridNum.Columns[1].HeaderText = "당첨 횟수";
        }
    }
}
