using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duello
{
    //inheritance dari class budget
    public class Income : Budget
    {
        //penerapan liskov substitution berupa class income dan expense dapat digunakan tanpa mengubah behavior budget
        public string infoIncome = "";
        public Income(string namaBudget, double jumlahUang, string inforIncome) : base(namaBudget, jumlahUang)
            => infoIncome = inforIncome;

        public override void LakukanPenjumlahanBudget()
        {
            tambahIncome(0, DateTime.Now, "");
        }
    }
}
