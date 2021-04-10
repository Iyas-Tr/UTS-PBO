using System;

namespace Duello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat datang di aplikasi budgeting anak kos Duello\nSilakan masukkan nama budget anda");
            string namaBudget = Console.ReadLine();
            Console.WriteLine("Silakan masukkan jumlah uang dari budget anda");
            double jumlahUang = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Budget dengan nama {namaBudget} dan jumlah {jumlahUang} IDR sudah dibuat!");
            var budget1 = new Budget(namaBudget, jumlahUang);

            Console.WriteLine("Selamat datang di menu utama. Silakan pilih apa yang ingin anda lakukan");
            bool Exit = false;
            while (!Exit)
            {
                Console.WriteLine("Masukkan 1 untuk tambah income.\n2 untuk tambah expense.");
                Console.WriteLine("3 untuk melihat seluruh income dan expense.\n4 untuk keluar dari aplikasi.");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Masukkan nama income");
                        string namaIncome = Console.ReadLine();
                        Console.WriteLine("Masukkan jumlah income");
                        double jumlahIncome = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Masukkan keterangan income");
                        string infoIncome = Console.ReadLine();
                        Console.WriteLine($"Income {namaIncome} dengan informasi {infoIncome} dan jumlah {jumlahIncome} IDR sudah dibuat");
                        budget1.tambahIncome(jumlahIncome, DateTime.Now, namaIncome);
                        var income = new Income(namaIncome, jumlahIncome, infoIncome);
                        Exit = false;
                        break;

                    case 2:
                        Console.WriteLine("Masukkan nama expense");
                        string namaExpense = Console.ReadLine();
                        Console.WriteLine("Masukkan jumlah expense");
                        double jumlahExpense = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Masukkan keterangan expense");
                        string infoExpense = Console.ReadLine();
                        Console.WriteLine($"Expense {namaExpense} dengan informasi {infoExpense} dan jumlah {jumlahExpense} IDR sudah dibuat");
                        budget1.tambahExpense(jumlahExpense, DateTime.Now, namaExpense);
                        var expense = new Expense(namaExpense, jumlahExpense, infoExpense);
                        Exit = false;
                        break;

                    case 3:
                        Console.WriteLine(budget1.GetBudgetHistory());
                        Exit = false;
                        break;

                    case 4:
                        Console.WriteLine("Selamat tinggal");
                        Exit = true;
                        break;
                }
            }
        }
    }
}
