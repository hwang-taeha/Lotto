using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoQuiz
{
    public partial class FrmPattern : Form
    {        
        DataRow dr;
        int drwNo;
        int ball1;
        int ball2;
        int ball3;
        int ball4;
        int ball5;
        int ball6;

        public FrmPattern()
        {
            InitializeComponent();
        }
                
        private void FrmPattern_Load(object sender, EventArgs e)
        {
            #region 그리드 뷰에 데이터 넣음
            DataTable dt = new DataTable();
            dt.Columns.Add("1");
            dt.Columns.Add("2");
            dt.Columns.Add("3");
            dt.Columns.Add("4");
            dt.Columns.Add("5");
            dt.Columns.Add("6");
            dt.Columns.Add("7");
            DataGridViewRowCollection dgv = new DataGridViewRowCollection(dataGridView1);

            for (int i = 0; i < 45;)
            {
                if (i % 7 == 0)
                {
                    dr = dt.NewRow();
                    dr[i % 7] = i + 1;
                    dt.Rows.Add(dr);
                }
                else
                {
                    dr[i % 7] = i + 1;
                }
                i++;
            }
            dataGridView1.DataSource = dt;
            #endregion
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            int[] balls = new int[6];
            dataGridView1.ClearSelection();
            
            // DataGridView viewPattern = new DataGridView();
            foreach (var item in WebToDB.dataLst)
            {
                if (numDrwNo.Value == item.DrwNo)
                {                                       
                    drwNo = item.DrwNo;
                    balls[0] = item.No1;
                    balls[1] = item.No2;
                    balls[2] = item.No3;
                    balls[3] = item.No4;
                    balls[4] = item.No5;
                    balls[5] = item.No6;
                }
            }
            foreach (var item in balls)
            {
                if(item%7 == 0)
                {
                    dataGridView1.Rows[(item / 7) - 1].Cells[(item % 7) + 6].Selected = true;
                }
                else
                {
                    dataGridView1.Rows[item / 7].Cells[(item % 7) - 1].Selected = true; ;
                }
            }
        }
    }
}
