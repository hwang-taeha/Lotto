using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoQuiz
{
    class SectionCheck
    {
        private string oneToTen;
        private string eleToTwe;
        private string twoToThi;
        private string thiToFor;
        private string etc;
        private int drwNo;

        public SectionCheck(int drwNo, string oneToTen, string eleToTwe, string twoToThi, string thiToFor, string etc)
        {
            this.drwNo = drwNo;
            this.oneToTen = oneToTen;
            this.eleToTwe = eleToTwe;
            this.twoToThi = twoToThi;
            this.thiToFor = thiToFor;
            this.etc = etc;
        }

        public int DrwNo
        {
            get { return drwNo; }
            set { drwNo = value; }
        }

        public string Etc
        {
            get { return etc; }
            set { etc = value; }
        }

        public string ThiToFor
        {
            get { return thiToFor; }
            set { thiToFor = value; }
        }

        public string TwoToThi
        {
            get { return twoToThi; }
            set { twoToThi = value; }
        }

        public string EleToTwe
        {
            get { return eleToTwe; }
            set { eleToTwe = value; }
        }

        public string OneToTen
        {
            get { return oneToTen; }
            set { oneToTen = value; }
        }

    }
}
