using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoQuiz
{
    public partial class Form1_Sjm : Form
    {
        List<WebToDB> list = new List<WebToDB>(); //DB 에서 저장될 List
        List<WebToDB> beforeList = new List<WebToDB>(); // 입력된 값과 비교하여 각 번호 당첨 여부를 저장할 List
        List<int> numList = new List<int>(); //중복 검사 List
        WebToDB wtd;
        bool temp;

        private void Form1_Sjm_Load(object sender, EventArgs e)
        {
            //#region DB연결 및 List에 저장
            //string conStr = ConfigurationManager.ConnectionStrings["Lotto"].ConnectionString;

            //SqlConnection con = new SqlConnection(conStr);
            //try
            //{
            //    con.Open();
            //}
            //catch (Exception)
            //{


            //}

            //SqlCommand comm = new SqlCommand();
            //comm.Connection = con;
            //comm.CommandType = CommandType.StoredProcedure;
            //comm.CommandText = "SelectDB";

            //var dr = comm.ExecuteReader();
            //while (dr.Read())
            //{
            //    WebToDB.dataLst.Add(new WebToDB(Int32.Parse(dr["DRWNO"].ToString()), Int32.Parse(dr["NO1"].ToString()), Int32.Parse(dr["NO2"].ToString()), Int32.Parse(dr["NO3"].ToString()),
            //    Int32.Parse(dr["NO4"].ToString()), Int32.Parse(dr["NO5"].ToString()), Int32.Parse(dr["NO6"].ToString()), Int32.Parse(dr["BONUSNO"].ToString())));
            //}
            //dr.Close();
            //con.Close();
            //#endregion
        }

        private void txtNo1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public Form1_Sjm()
        {
            InitializeComponent();
        }

        #region 당첨여부 OX로 변환
        public string convert1or0(int j)
        {
            string result = "";
            if (j == 10 || j == 1)
            {
                result = "O";
            }
            else if (j == 0)
            {
                result = "X";
            }

            return result;
        }
        #endregion

        #region 중복 검사
        private void ExamineNum()
        {
            temp = false;
            for (int i = 0; i < 45; i++)
            {
                numList.Add(i + 1);
            }

            #region 중복확인
            try
            {

                if (numList.Contains(Int32.Parse(txtNo1.Text)))
                {
                    numList[Int32.Parse(txtNo1.Text) - 1] = 0;
                }
                if (numList.Contains(Int32.Parse(txtNo2.Text)))
                {
                    numList[Int32.Parse(txtNo2.Text) - 1] = 0;
                }
                else
                {
                    MessageBox.Show("숫자가 중복되었습니다.");
                    temp = true;
                    return;
                }
                if (numList.Contains(Int32.Parse(txtNo3.Text)))
                {
                    numList[Int32.Parse(txtNo3.Text) - 1] = 0;
                }
                else
                {
                    MessageBox.Show("숫자가 중복되었습니다.");
                    temp = true;
                    return;
                }
                if (numList.Contains(Int32.Parse(txtNo4.Text)))
                {
                    numList[Int32.Parse(txtNo4.Text) - 1] = 0;
                }
                else
                {
                    MessageBox.Show("숫자가 중복되었습니다.");
                    temp = true;
                    return;
                }
                if (numList.Contains(Int32.Parse(txtNo5.Text)))
                {
                    numList[Int32.Parse(txtNo5.Text) - 1] = 0;
                }
                else
                {
                    MessageBox.Show("숫자가 중복되었습니다.");
                    temp = true;
                    return;
                }
                if (numList.Contains(Int32.Parse(txtNo6.Text)))
                {
                    numList[Int32.Parse(txtNo6.Text) - 1] = 0;
                }
                else
                {
                    MessageBox.Show("숫자가 중복되었습니다.");
                    temp = true;
                    return;
                }
                
                string[] sortNum = new string[6];
                int j = 0;
                for (int i = 0; i < numList.Count; i++)
                {
                    if (numList[i]==0)
                    {
                        sortNum[j] = (i+1)+"";
                        j++;
                    } 
                }
                this.txtNo1.Text = sortNum[0];
                this.txtNo2.Text = sortNum[1];
                this.txtNo3.Text = sortNum[2];
                this.txtNo4.Text = sortNum[3];
                this.txtNo5.Text = sortNum[4];
                this.txtNo6.Text = sortNum[5];
            }
            catch (Exception)
            {
                MessageBox.Show("숫자를 모두 입력해주세요","오류",MessageBoxButtons.OK,MessageBoxIcon.Error);
                temp = true;
            }
            #endregion
            numList.Clear();
        } 
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            ExamineNum();//중복 검사
            #region 중복일때 초기화작업
            if (temp == true)
            {
                txtNo1.Text = txtNo2.Text = txtNo3.Text = txtNo4.Text = txtNo5.Text = txtNo6.Text="";
                numList.Clear();
                DBGridView.DataSource = "";
                beforeList.Clear();
                return;
            } 
            #endregion
            DataTable dataTable = new DataTable();

            #region 공백제거
            this.txtNo1.Text = this.txtNo1.Text.Replace(" ", "").Trim();
            this.txtNo2.Text = this.txtNo2.Text.Replace(" ", "").Trim();
            this.txtNo3.Text = this.txtNo3.Text.Replace(" ", "").Trim();
            this.txtNo4.Text = this.txtNo4.Text.Replace(" ", "").Trim();
            this.txtNo5.Text = this.txtNo5.Text.Replace(" ", "").Trim();
            this.txtNo6.Text = this.txtNo6.Text.Replace(" ", "").Trim();
            #endregion



            #region 데이터테이블 컬럼추가
            dataTable.Columns.Add("회차");
            dataTable.Columns.Add("등수");
            dataTable.Columns.Add("No1\n" + this.txtNo1.Text);
            dataTable.Columns.Add("No2\n" + this.txtNo2.Text);
            dataTable.Columns.Add("No3\n" + this.txtNo3.Text);
            dataTable.Columns.Add("No4\n" + this.txtNo4.Text);
            dataTable.Columns.Add("No5\n" + this.txtNo5.Text);
            dataTable.Columns.Add("No6\n" + this.txtNo6.Text);
            dataTable.Columns.Add("Bonus\n");

            #endregion


            DBGridView.DataSource = "";
            beforeList.Clear();
            string[] num = new string[] { this.txtNo1.Text, this.txtNo2.Text, this.txtNo3.Text, this.txtNo4.Text, this.txtNo5.Text, this.txtNo6.Text };
            #region 당첨여부 저장
            foreach (var item in WebToDB.dataLst)
            {
                wtd = new WebToDB();
                wtd.No1 = wtd.No2 = wtd.No3 = wtd.No4 = wtd.No5 = wtd.No6 = wtd.BonusNo = 0;
                if (this.txtNo1.Text == item.No1 + "")
                {
                    wtd.No1 = 10;
                }
                if (this.txtNo2.Text == item.No2 + "")
                {
                    wtd.No2 = 10;
                }
                if (this.txtNo3.Text == item.No3 + "")
                {
                    wtd.No3 = 10;
                }
                if (this.txtNo4.Text == item.No4 + "")
                {
                    wtd.No4 = 10;
                }
                if (this.txtNo5.Text == item.No5 + "")
                {
                    wtd.No5 = 10;
                }
                if (this.txtNo6.Text == item.No6 + "")
                {
                    wtd.No6 = 10;
                }
                string numBonus = "";
                int[] numOX = new int[] { wtd.No1, wtd.No2, wtd.No3, wtd.No4, wtd.No5, wtd.No6 }; //당첨여부에 대한 Array
                
                if (wtd.No1+wtd.No2+ wtd.No3+ wtd.No4+ wtd.No5+ wtd.No6 == 50)
                {
                    
                    for (int i = 0; i < numOX.Length; i++)
                    {
                        if (numOX[i] == 0)
                        {
                            if (Int32.Parse(num[i])==item.BonusNo)
                            {
                                numBonus = num[i];
                                wtd.BonusNo = 1; //2,3등을 구분하기 위해 1로 저장
                            }
                        }
                    }
                    
                }
                
                if (wtd.No1 + wtd.No2 + wtd.No3 + wtd.No4 + wtd.No5 + wtd.No6 > 21) // 5등이상 리스트에 저장
                {
                    
                    wtd.DrwNo = item.DrwNo;
                    beforeList.Add(wtd);
                    RowAdd(dataTable, wtd, numBonus);//등수 매기기

                }
            }
            #endregion

            #region 컬럼 header 이름 변경
            DBGridView.DataSource = dataTable;
            DBGridView.Columns["회차"].Width = 40;
            DBGridView.Columns["등수"].Width = 40;
            DBGridView.Columns["No1\n" + this.txtNo1.Text].Width = 40;
            DBGridView.Columns["No2\n" + this.txtNo2.Text].Width = 40;
            DBGridView.Columns["No3\n" + this.txtNo3.Text].Width = 40;
            DBGridView.Columns["No4\n" + this.txtNo4.Text].Width = 40;
            DBGridView.Columns["No5\n" + this.txtNo5.Text].Width = 40;
            DBGridView.Columns["No6\n" + this.txtNo6.Text].Width = 40;
            DBGridView.Columns["Bonus\n"].Width = 70;
            DBGridView.Sort(DBGridView.Columns["등수"], ListSortDirection.Ascending);
            #endregion
            //DBGridView.Sort
            txtNo1.Text = txtNo2.Text = txtNo3.Text = txtNo4.Text = txtNo5.Text = txtNo6.Text = "";
        }
        #region 등수 매기기
        private void RowAdd(DataTable dataTable, WebToDB RowAdd_wtd, string numBonus)
        {
            DataRow dr = dataTable.NewRow();
            dr["회차"] = RowAdd_wtd.DrwNo;
            int sum = RowAdd_wtd.No1 + RowAdd_wtd.No2 + RowAdd_wtd.No3 + RowAdd_wtd.No4 + RowAdd_wtd.No5 + RowAdd_wtd.No6 + RowAdd_wtd.BonusNo;
            if (sum >= 60)
            {
                dr["등수"] = 1;
            }
            else if (sum == 51)
            {
                dr["등수"] = 2;
            }
            else if (sum == 50)
            {
                dr["등수"] = 3;
            }
            else if (sum >= 40)
            {
                dr["등수"] = 4;
            }
            else if (sum >= 30)
            {
                dr["등수"] = 5;
            }

            dr["No1\n" + this.txtNo1.Text] = convert1or0(RowAdd_wtd.No1);
            dr["No2\n" + this.txtNo2.Text] = convert1or0(RowAdd_wtd.No2);
            dr["No3\n" + this.txtNo3.Text] = convert1or0(RowAdd_wtd.No3);
            dr["No4\n" + this.txtNo4.Text] = convert1or0(RowAdd_wtd.No4);
            dr["No5\n" + this.txtNo5.Text] = convert1or0(RowAdd_wtd.No5);
            dr["No6\n" + this.txtNo6.Text] = convert1or0(RowAdd_wtd.No6);
            dr["Bonus\n"] = convert1or0(RowAdd_wtd.BonusNo)+" "+numBonus;
            dataTable.Rows.Add(dr);
        }
        #endregion

        #region 1~45 외 입력 제한
        private void txtNo1_TextChanged_1(object sender, EventArgs e)
            {
            string a = ((TextBox)sender).Text;


            try
            {
                if (!(Int32.Parse(a) >= 1 && Int32.Parse(a) <= 45))
                {
                    ((TextBox)sender).Text = "";
                    MessageBox.Show("1~45 사이 숫자를 입력해주세요");
                }
            }
            catch (Exception)
            {
                ((TextBox)sender).Text = "";
            }

        }

        #endregion

        private void Form1_Sjm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
