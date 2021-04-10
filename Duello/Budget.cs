using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duello
{
    public class Budget
    {
        public string namaBudget { get; set; }
        public double jumlahUang { get; set; }
        public Budget(string namaBudget, double jumlahUang)
        {
            this.namaBudget = namaBudget;
            this.jumlahUang = jumlahUang;
        }
        private List<TotalBudget> allTotal = new List<TotalBudget>();
        public void tambahIncome(double jumlahIncome, DateTime date, string namaIncome)
        {
            if (jumlahIncome <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(jumlahIncome), "Income tidak boleh bernilai negatif");
            }
            var income = new TotalBudget(jumlahIncome, date, namaIncome);
            allTotal.Add(income);
        }
        public void tambahExpense(double jumlahExpense, DateTime date, string namaExpense)
        {
            if (jumlahExpense <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(jumlahExpense), "Expense tidak boleh bernilai negatif");
            }
            var expense = new TotalBudget(-jumlahExpense, date, namaExpense);
            allTotal.Add(expense);
        }
        public string GetBudgetHistory()
        {
            var report = new System.Text.StringBuilder();

            double jumlahUang = 0;
            report.AppendLine("Tanggal\t\tJumlah\tBudget\tNota");
            foreach (var item in allTotal)
            {
                jumlahUang += item.Jumlah;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Jumlah}\t{jumlahUang}\t{item.Nama}");
            }

            return report.ToString();
        }
        public virtual void LakukanPenjumlahanBudget() { }
    }
}
