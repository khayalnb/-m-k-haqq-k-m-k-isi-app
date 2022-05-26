using System;
using ConsoleTables;

namespace emek_haqqi_komekcisi_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            WarningMessage warningMessage = new WarningMessage();
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*Emek haqqının hesablanması*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine();
            Console.Write(warningMessage.enterSalaryMessage);
            int salary; 
            string employeeSalary = Console.ReadLine();
            while (!int.TryParse(employeeSalary, out salary))
            {
                if (string.IsNullOrWhiteSpace(employeeSalary))
                {
                    Console.WriteLine(warningMessage.emptyValueMessage);
                }
                if (!string.IsNullOrWhiteSpace(employeeSalary))
                {
                    if (employeeSalary.GetType() == typeof(string))
                    {
                        Console.WriteLine(warningMessage.wrongLetterMessage);
                    }
                }
               
                Console.WriteLine(warningMessage.wrongSalaryMessage);
                Console.Write(warningMessage.enterSalaryMessage);
                employeeSalary = Console.ReadLine();
            }
            Console.WriteLine(warningMessage.confirmationSalaryMessage);
            Console.Write(warningMessage.enterMessage);
            string employeeSalaryConfidenceResponse = Console.ReadLine();
            int employeeSalaryResponseNumber;
            while (!int.TryParse(employeeSalaryConfidenceResponse,out employeeSalaryResponseNumber))
            {
                if (string.IsNullOrWhiteSpace(employeeSalaryConfidenceResponse))
                {
                    Console.WriteLine(warningMessage.emptyValueMessage);
                }
                if (!string.IsNullOrWhiteSpace(employeeSalaryConfidenceResponse))
                {
                    if (employeeSalaryConfidenceResponse.GetType() == typeof(string))
                    {
                        Console.WriteLine(warningMessage.wrongLetterMessage);
                    }
                }
                Console.WriteLine(warningMessage.wrongValueMessage);
                Console.WriteLine("Bəli(1) / Xeyr(2)");
                employeeSalaryConfidenceResponse = Console.ReadLine();
            }
            if (employeeSalaryResponseNumber!=1)
            {
                Console.Write(warningMessage.enterSalaryMessage);
                while (!int.TryParse(employeeSalary, out salary))
                {
                    Console.WriteLine(warningMessage.wrongSalaryMessage);
                    Console.Write(warningMessage.enterSalaryMessage);
                    employeeSalary = Console.ReadLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine(warningMessage.enterMartialStatusMessage);
            Console.WriteLine("Evli (1) / Subay (2) / Dul (3)");
            Console.Write(warningMessage.enterMessage);
            int maritalStatusResponse;
            string martialStatus = Console.ReadLine();
            while (!int.TryParse(martialStatus, out maritalStatusResponse))
            {
                Console.WriteLine(warningMessage.wrongMaritalStatusMessage);
                martialStatus = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine(warningMessage.confirmationMartialStatusMessage);
            Console.Write(warningMessage.enterMessage);
            string martialStatusConfidenceResponse = Console.ReadLine();
            int martialStatusConfidenceResponseNumber;
            while (!int.TryParse(martialStatusConfidenceResponse,out martialStatusConfidenceResponseNumber))
            {
                Console.WriteLine(warningMessage.wrongValueMessage);
                martialStatusConfidenceResponse = Console.ReadLine();
            }
            switch (martialStatusConfidenceResponseNumber)
            {
                case 1:
                    Console.WriteLine(warningMessage.successfulMessage);
                    break;
                case 2:
                    Console.WriteLine("Bəli(1) / Xeyr(2)");
                    martialStatus = Console.ReadLine();
                    while (!int.TryParse(martialStatus, out maritalStatusResponse))
                    {
                        Console.WriteLine(warningMessage.wrongMaritalStatusMessage);
                    }
                    break;
                default:
                    Console.WriteLine(warningMessage.wrongValueMessage);
                    break;
            }
            Console.WriteLine();
            int payment = 0;
            int childCount=0;
            int marriedPayment = 50;
            if (maritalStatusResponse==1 || maritalStatusResponse==3)
            {
                if (maritalStatusResponse==1)
                {
                    salary += marriedPayment;
                }
                Console.WriteLine(warningMessage.confirmationDoHaveChildMessage);
                int childResponseConfiderinceNumber;
                Console.Write(warningMessage.enterMessage);
                string haveChildResponse = Console.ReadLine();
                while (!int.TryParse(haveChildResponse,out childResponseConfiderinceNumber))
                {
                    Console.WriteLine(warningMessage.wrongValueMessage);
                    haveChildResponse = Console.ReadLine();
                }
                if (childResponseConfiderinceNumber == 1)
                {
                    Console.WriteLine();
                    Console.Write(warningMessage.enterChildCountMessage);
                    
                    string childCountresponse = Console.ReadLine();
                    while (!int.TryParse(childCountresponse,out childCount))
                    {
                        Console.WriteLine(warningMessage.wrongChildCountMessage);
                        childCountresponse = Console.ReadLine();
                    }
                    if (childCount == 1)
                    { 
                        payment += 30;
                        salary += 30;
                        warningMessage.childPaymentMessage(payment);
                    }
                    if (childCount == 2)
                    {
                        payment += 30 + 25;
                        salary = 30 + 25;
                        warningMessage.childPaymentMessage(payment);
                    }
                    if (childCount == 3)
                    {
                        payment = 30 + 25 + 20;
                        salary = 30 + 25 + 20;
                        warningMessage.childPaymentMessage(payment);
                    }
                    if (childCount > 3)
                    {
                        payment= 30 + 25 + 20 + ((childCount - 3) * 15);
                        salary += 30 + 25 + 20 + ((childCount - 3) * 15);
                        warningMessage.childPaymentMessage(payment);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(warningMessage.disabilityMessage);
            int disabilityStatusNumber;
            
            double taxInterest = 0;
            double fixSalary = 0;
            float interest = 0;
            bool isContunie = true;
            do
            {
                Console.WriteLine(warningMessage.enterMessage);
                string disabilityStatus = Console.ReadLine();
                while (!int.TryParse(disabilityStatus, out disabilityStatusNumber))
                {
                    Console.WriteLine(warningMessage.wrongValueMessage);
                    disabilityStatus = Console.ReadLine();
                }

                if (disabilityStatusNumber == 1)
                {
                    isContunie = true;
                    const float divisor = 2f;
                    float a = 100;
                    if (salary <= 1000)
                    {
                        interest = 15 / divisor;
                        taxInterest = (salary / a) * interest;
                        fixSalary = Math.Floor(salary - taxInterest);
                    }
                    if (salary > 1000 && salary <= 2000)
                    {
                        interest = 20 / divisor;
                        taxInterest = (salary / 100) * interest;
                        fixSalary = Math.Floor(salary - taxInterest);
                    }
                    if (salary > 2000 && salary <= 3000)
                    {
                        interest = 25 / divisor;
                        taxInterest = (salary / 100) * interest;
                        fixSalary = Math.Floor(salary - taxInterest);
                    }
                    if (salary > 3000)
                    {
                        interest = 30 / divisor;
                        taxInterest = ((salary / 100) * interest);
                        fixSalary = Math.Round(salary - taxInterest);
                    }
                }
                else if (disabilityStatusNumber == 2)
                {
                    isContunie = true;
                    if (salary <= 1000)
                    {

                        taxInterest = (salary / 100) * 15;
                        fixSalary = salary - taxInterest;
                    }
                    if (salary > 1000 && salary <= 2000)
                    {
                        taxInterest = (salary / 100) * 20;
                        fixSalary = salary - taxInterest;
                    }
                    if (salary > 2000 && salary <= 3000)
                    {
                        taxInterest = (salary / 100) * 25;
                        fixSalary = salary - taxInterest;
                    }
                    if (salary > 3000)
                    {
                        taxInterest = (salary / 100) * 30;
                        fixSalary = salary - taxInterest;
                    }
                }
                else if (disabilityStatusNumber != 1 || disabilityStatusNumber != 2)
                {
                    Console.WriteLine(warningMessage.wrongValueMessage);
                    isContunie = false;
                }
            } while (!isContunie);
           

            var table = new ConsoleTable("Ailə müavinatı", "Uşaq pulu", "Gəlir vergisi dərəcəsi", "Gəlir vergisi məbləği", "Ümumi əmək haqqı", "Xalis əmək haqqı");
            table.AddRow(marriedPayment, payment, interest + " %", taxInterest, salary, fixSalary);
            table.Write();
            Console.WriteLine("Sizin əmək haqqınız bu pul vahidləri ilə ödəniləcək :");
            paymentTerminal(fixSalary);
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
        public static void paymentTerminal(double salary)
        {
            int[] monetaryUnits = { 200, 100, 50, 20, 10, 5, 1 };
           
            for (int i = 0; i < monetaryUnits.Length; i++)
            {
                int moneyUnitCount =Convert.ToInt32( Math.Floor(salary / monetaryUnits[i]));
                if (moneyUnitCount != 0)
                {
                    var moneyTable = new ConsoleTable(monetaryUnits[i].ToString()+" AZN ");
                    moneyTable.AddRow(moneyUnitCount);
                    Console.WriteLine(moneyTable);
                    //Console.WriteLine("{0} eded {1} manat çıxarıldı", moneyUnitCount, monetaryUnits[i]);
                }
                salary = salary - (moneyUnitCount * monetaryUnits[i]);
            }
        }
    }
}
