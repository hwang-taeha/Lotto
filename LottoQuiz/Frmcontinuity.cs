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
        int currentDrwNO = 20;//그리드 뷰에 출력되는 마지막 회차
        //int[,] duplicateNumber;

        private void Frmcontinuity_Load(object sender, EventArgs e)
        {
            //  duplicateNumber = new int[WebToDB.dataLst.Count, 6];


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("회차");
            dataTable.Columns.Add("숫자1");
            dataTable.Columns.Add("숫자2");
            dataTable.Columns.Add("숫자3");
            dataTable.Columns.Add("숫자4");
            dataTable.Columns.Add("숫자5");
            dataTable.Columns.Add("숫자6");

            for (int i = 0; i < currentDrwNO; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["회차"] = WebToDB.dataLst[i].DrwNo;
                dataRow["숫자1"] = WebToDB.dataLst[i].No1;
                dataRow["숫자2"] = WebToDB.dataLst[i].No2;
                dataRow["숫자3"] = WebToDB.dataLst[i].No3;
                dataRow["숫자4"] = WebToDB.dataLst[i].No4;
                dataRow["숫자5"] = WebToDB.dataLst[i].No5;
                dataRow["숫자6"] = WebToDB.dataLst[i].No6;

                dataTable.Rows.Add(dataRow);
            }
            dgvView.DataSource = dataTable;

            for (int i = 0; i < dgvView.RowCount - 1; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if (int.Parse(dgvView.Rows[i].Cells[j].Value.ToString()) + 1 == int.Parse(dgvView.Rows[i].Cells[j + 1].Value.ToString()))
                    {
                        dgvView.Rows[i].Cells[j].Style.BackColor = dgvView.Rows[i].Cells[j + 1].Style.BackColor = Color.Turquoise;
                    }
                }
            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("회차");
            dataTable.Columns.Add("숫자1");
            dataTable.Columns.Add("숫자2");
            dataTable.Columns.Add("숫자3");
            dataTable.Columns.Add("숫자4");
            dataTable.Columns.Add("숫자5");
            dataTable.Columns.Add("숫자6");

            for (int i = 0; i < WebToDB.dataLst.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["회차"] = WebToDB.dataLst[i].DrwNo;
                dataRow["숫자1"] = WebToDB.dataLst[i].No1;
                dataRow["숫자2"] = WebToDB.dataLst[i].No2;
                dataRow["숫자3"] = WebToDB.dataLst[i].No3;
                dataRow["숫자4"] = WebToDB.dataLst[i].No4;
                dataRow["숫자5"] = WebToDB.dataLst[i].No5;
                dataRow["숫자6"] = WebToDB.dataLst[i].No6;

                dataTable.Rows.Add(dataRow);
            }
            dgvView.DataSource = dataTable;

            for (int i = 0; i < dgvView.RowCount - 1; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if (int.Parse(dgvView.Rows[i].Cells[j].Value.ToString()) + 1 == int.Parse(dgvView.Rows[i].Cells[j + 1].Value.ToString()))
                    {
                        dgvView.Rows[i].Cells[j].Style.BackColor = dgvView.Rows[i].Cells[j + 1].Style.BackColor = Color.Turquoise;
                    }
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            if (currentDrwNO > 20)
            {
                currentDrwNO -= 20;
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("회차");
                dataTable.Columns.Add("숫자1");
                dataTable.Columns.Add("숫자2");
                dataTable.Columns.Add("숫자3");
                dataTable.Columns.Add("숫자4");
                dataTable.Columns.Add("숫자5");
                dataTable.Columns.Add("숫자6");

                for (int i = currentDrwNO - 20; i < currentDrwNO; i++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["회차"] = WebToDB.dataLst[i].DrwNo;
                    dataRow["숫자1"] = WebToDB.dataLst[i].No1;
                    dataRow["숫자2"] = WebToDB.dataLst[i].No2;
                    dataRow["숫자3"] = WebToDB.dataLst[i].No3;
                    dataRow["숫자4"] = WebToDB.dataLst[i].No4;
                    dataRow["숫자5"] = WebToDB.dataLst[i].No5;
                    dataRow["숫자6"] = WebToDB.dataLst[i].No6;

                    dataTable.Rows.Add(dataRow);
                }
                dgvView.DataSource = dataTable;

                for (int i = 0; i < dgvView.RowCount - 1; i++)
                {
                    for (int j = 1; j < 6; j++)
                    {
                        if (int.Parse(dgvView.Rows[i].Cells[j].Value.ToString()) + 1 == int.Parse(dgvView.Rows[i].Cells[j + 1].Value.ToString()))
                        {
                            dgvView.Rows[i].Cells[j].Style.BackColor = dgvView.Rows[i].Cells[j + 1].Style.BackColor = Color.Turquoise;
                        }
                    }
                }

            }
        }
        public int ListOverflow(int num)
        {

            int temp;
            if (WebToDB.dataLst.Count - currentDrwNO < 20)
            {
                temp = WebToDB.dataLst.Count;
                return temp;
            }
            else
            {
                return currentDrwNO;
            }
        }

        private void btnfront_Click(object sender, EventArgs e)
        {

            if (currentDrwNO < WebToDB.dataLst.Count)
            {
                currentDrwNO += 20;
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("회차");
                dataTable.Columns.Add("숫자1");
                dataTable.Columns.Add("숫자2");
                dataTable.Columns.Add("숫자3");
                dataTable.Columns.Add("숫자4");
                dataTable.Columns.Add("숫자5");
                dataTable.Columns.Add("숫자6");

                for (int i = currentDrwNO - 20; i < ListOverflow(currentDrwNO); i++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["회차"] = WebToDB.dataLst[i].DrwNo;
                    dataRow["숫자1"] = WebToDB.dataLst[i].No1;
                    dataRow["숫자2"] = WebToDB.dataLst[i].No2;
                    dataRow["숫자3"] = WebToDB.dataLst[i].No3;
                    dataRow["숫자4"] = WebToDB.dataLst[i].No4;
                    dataRow["숫자5"] = WebToDB.dataLst[i].No5;
                    dataRow["숫자6"] = WebToDB.dataLst[i].No6;

                    dataTable.Rows.Add(dataRow);
                }
                dgvView.DataSource = dataTable;

                for (int i = 0; i < dgvView.RowCount - 1; i++)
                {
                    for (int j = 1; j < 6; j++)
                    {
                        if (int.Parse(dgvView.Rows[i].Cells[j].Value.ToString()) + 1 == int.Parse(dgvView.Rows[i].Cells[j + 1].Value.ToString()))
                        {
                            dgvView.Rows[i].Cells[j].Style.BackColor = dgvView.Rows[i].Cells[j + 1].Style.BackColor = Color.Turquoise;
                        }
                    }
                }
            }

        }
    }
}

