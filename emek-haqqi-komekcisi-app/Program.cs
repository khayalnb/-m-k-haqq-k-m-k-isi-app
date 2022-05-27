using System;
using ConsoleTables;

namespace emek_haqqi_komekcisi_app
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryManager salaryManager = new SalaryManager();
            salaryManager.Manager();
        }
        public static int TrueAndFalseResponse(string value)
        {
            int result;
            while (!int.TryParse(value, out result))
            {
                Console.WriteLine("Zəhmət olmasa əmək haqqını düzgün daxil edin!");
                Console.Write("Əmək haqqını daxil edin :");
                value = Console.ReadLine();
            }
            return result;
        }
      
    }
}
