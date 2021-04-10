using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duello
{
    public class Expense : Budget
    {
        public string infoExpense = "";
        public Expense(string namaBudget, double jumlahUang, string inforExpense) : base(namaBudget, jumlahUang)
            => infoExpense = inforExpense;
        public override void LakukanPenjumlahanBudget()
        {
            tambahExpense(0, DateTime.Now, "");
        }
    }
}
