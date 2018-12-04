using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoQuiz
{
    class LottoData
    {
        private string rank;

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        private string total;

        public string Total
        {
            get { return total; }
            set { total = value; }
        }

        private string gamecount;

        public string Gamecount
        {
            get { return gamecount; }
            set { gamecount = value; }
        }

        private string won;

        public string Won
        {
            get { return won; }
            set { won = value; }
        }

        public LottoData(string rank, string total, string gamecount, string won)
        {
            this.rank = rank;
            this.total = total;
            this.gamecount = gamecount;
            this.won = won;
        }
    }
}
