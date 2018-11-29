using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoQuiz
{
    public class Check
    {
        private string odd;
        private string even;
        private int drwNo;

        public Check(int drwNo, string odd, string even)
        {
            this.odd = odd;
            this.even = even;
            this.drwNo = drwNo;
        }
        public int DrwNo
        {
            get { return drwNo; }
            set { drwNo = value; }
        }
        public string Odd
        {
            get { return odd; }
            set { odd = value; }
        }

        public string Even
        {
            get { return even; }
            set { even = value; }
        }

    }
}
