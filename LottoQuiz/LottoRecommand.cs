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
    public partial class LottoRecommand : Form
    {

        DataTable DataTable = new DataTable();

        int[] lottoNumbers_count = new int[45]; //번호별 뽑힌 횟수
        List<int> recommandNumbers = new List<int>(); //추천할 번호들이 모여있는 리스트
        int[] recommandationNumbers = new int[6];  //추천할 6개의 번호
        public LottoRecommand()
        {
            InitializeComponent();
        }

        private void LottoRecommand_Load(object sender, EventArgs e)
        { 
            ////회차별 뽑힌 번호들을 숫자별로 count하여 저장
            foreach (var item in WebToDB.dataLst)
            {
                lottoNumbers_count[item.No1 - 1]++; //배열은 0번째 부터라
                lottoNumbers_count[item.No2 - 1]++;
                lottoNumbers_count[item.No3 - 1]++;
                lottoNumbers_count[item.No4 - 1]++;
                lottoNumbers_count[item.No5 - 1]++;
                lottoNumbers_count[item.No6 - 1]++;
            }

            //각각의 숫자들의 확률(뽑힌 횟수/전체)을 계산하여 그만큼의 갯수만큼 추천번호 리스트에 추가시켜 Random함수 사용시 확률을 높여줌

            for (int i = 1; i < lottoNumbers_count.Length + 1; i++)
            {
                float percentCount = (lottoNumbers_count[i - 1] / ((float)WebToDB.dataLst.Count * 45)) * 1000000; //배열은 0부터

                for (int j = 0; j < percentCount; j++)
                {
                    recommandNumbers.Add(i);
                }
                
            }
            DataTable.Columns.Add("숫자1");
            DataTable.Columns.Add("숫자2");
            DataTable.Columns.Add("숫자3");
            DataTable.Columns.Add("숫자4");
            DataTable.Columns.Add("숫자5");
            DataTable.Columns.Add("숫자6");

        }

        #region 중복확인 메서드
        private bool DuplicationSearch(int[] recommandationNumbers, int randomNumber, int currentArrayValue)
        {
            bool retrunValue = true;
            foreach (var item in recommandationNumbers)
            {
                for (int i = 0; i < currentArrayValue + 1; i++)
                {
                    if (recommandationNumbers[i] == recommandNumbers[randomNumber])
                    {
                        retrunValue = false;
                        break;
                    }
                }
            }
            return retrunValue;
        }

        private bool DuplicationSearch(int[] recommandationNumbers, int randomNumber)
        {
            bool retrunValue = true;
            foreach (var item in recommandationNumbers)
            {
                if (item == recommandNumbers[randomNumber])
                {
                    retrunValue = false;
                    break;
                }
            }
            return retrunValue;
        }
        #endregion

        private void btnRecommand_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < recommandationNumbers.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, recommandNumbers.Count - 1);
                    if (DuplicationSearch(recommandationNumbers, temp, i))//랜덤한 수를 뽑는다 추천된 배열에서
                    {
                        recommandationNumbers[i] = recommandNumbers[temp];  //recommandationNumbers에 값을 넣는다.
                        break;
                    }
                }
            }
            
            DataRow dataRow = DataTable.NewRow();

            insertionSort(recommandationNumbers);

            dataRow["숫자1"] = recommandationNumbers[0];
            dataRow["숫자2"] = recommandationNumbers[1];
            dataRow["숫자3"] = recommandationNumbers[2];
            dataRow["숫자4"] = recommandationNumbers[3];
            dataRow["숫자5"] = recommandationNumbers[4];
            dataRow["숫자6"] = recommandationNumbers[5];

           
            DataTable.Rows.Add(dataRow);
            dgvNumvers.DataSource = DataTable;
        }
        #region sort
        /// <summary>
        /// 삽입sort
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] insertionSort(int[] arr)
        {

            for (int index = 1; index < arr.Length; index++)
            {

                int temp = arr[index];
                int aux = index - 1;

                while ((aux >= 0) && (arr[aux] > temp))
                {

                    arr[aux + 1] = arr[aux];
                    aux--;
                }
                arr[aux + 1] = temp;
            }
            return arr;
        } 
        #endregion

    }
}
