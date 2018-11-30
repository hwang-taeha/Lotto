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
    public partial class Frmcontinuity : Form
    {
        public Frmcontinuity()
        {
            InitializeComponent();
        }
        int[,] duplicateNumber;

        private void Frmcontinuity_Load(object sender, EventArgs e)
        {
            duplicateNumber = new int[WebToDB.dataLst.Count, 6];
            

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("숫자1");
            dataTable.Columns.Add("숫자2");
            dataTable.Columns.Add("숫자3");
            dataTable.Columns.Add("숫자4");
            dataTable.Columns.Add("숫자5");
            dataTable.Columns.Add("숫자6");

            for (int i = 0; i < WebToDB.dataLst.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["숫자1"] = WebToDB.dataLst[i].No1;
                dataRow["숫자2"] = WebToDB.dataLst[i].No2;
                dataRow["숫자3"] = WebToDB.dataLst[i].No3;
                dataRow["숫자4"] = WebToDB.dataLst[i].No4;
                dataRow["숫자5"] = WebToDB.dataLst[i].No5;
                dataRow["숫자6"] = WebToDB.dataLst[i].No6;

                for (int j = 1; j < 6; j++)
                {
                    if (dataRow["숫자" + j] == dataRow["숫자" + j+1])
                    {
                        
                    } 
                }


                dataTable.Rows.Add(dataRow);
            }

            //foreach (var item in WebToDB.dataLst)
            //{
            //    DataRow dataRow = dataTable.NewRow();
            //    dataRow["숫자1"] = item.No1;
            //    dataRow["숫자2"] = item.No2;
            //    dataRow["숫자3"] = item.No3;
            //    dataRow["숫자4"] = item.No4;
            //    dataRow["숫자5"] = item.No5;
            //    dataRow["숫자6"] = item.No6;

                

            //    dataTable.Rows.Add(dataRow);
            //}
            dgvView.DataSource = dataTable;

        }
    }
}
