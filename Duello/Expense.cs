using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duello
{
    //inheritance dari class budget
    public class Expense : Budget
    {
        //penerapan liskov substitution berupa class income dan expense dapat digunakan tanpa mengubah behavior budget
        public string infoExpense = "";
        public Expense(string namaBudget, double jumlahUang, string inforExpense) : base(namaBudget, jumlahUang)
            => infoExpense = inforExpense;
        public override void LakukanPenjumlahanBudget()
        {
            tambahExpense(0, DateTime.Now, "");
        }
    }
}
