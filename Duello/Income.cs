using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duello
{
    public class Income : Budget
    {
        public string infoIncome = "";
        public Income(string namaBudget, double jumlahUang, string inforIncome) : base(namaBudget, jumlahUang)
            => infoIncome = inforIncome;

        public override void LakukanPenjumlahanBudget()
        {
            tambahIncome(0, DateTime.Now, "");
        }
    }
}
