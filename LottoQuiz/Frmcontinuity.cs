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

        private void Frmcontinuity_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("숫자1");
            dataTable.Columns.Add("숫자2");
            dataTable.Columns.Add("숫자3");
            dataTable.Columns.Add("숫자4");
            dataTable.Columns.Add("숫자5");
            dataTable.Columns.Add("숫자6");


        }
    }
}
