using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duello
{
    //class yang mengenkapsulasi proses penghitungan budget setelah income dan expense
    public class TotalBudget
    {
        public double Jumlah { get; }
        public DateTime Date { get; }
        public string Nama { get; }

        public TotalBudget(double jumlah, DateTime date, string nama)
        {
            this.Jumlah = jumlah;
            this.Date = date;
            this.Nama = nama;
        }
    }
}
