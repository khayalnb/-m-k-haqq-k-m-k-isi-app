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
            int employeeSalaryResponseNumber;
            bool isSalaryResponseContiune = false;
            do
            {
                Console.Write(warningMessage.enterMessage);
                string employeeSalaryConfidenceResponse = Console.ReadLine();
                while (!int.TryParse(employeeSalaryConfidenceResponse, out employeeSalaryResponseNumber))
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
                    Console.Write(warningMessage.enterMessage);
                    employeeSalaryConfidenceResponse = Console.ReadLine();
                }
                isSalaryResponseContiune = true;
                if (employeeSalaryResponseNumber == 2)
                {
                    Console.Write(warningMessage.enterSalaryMessage);
                    while (!int.TryParse(employeeSalary, out salary))
                    {
                        Console.WriteLine(warningMessage.wrongSalaryMessage);
                        Console.Write(warningMessage.enterSalaryMessage);
                        employeeSalary = Console.ReadLine();
                        isSalaryResponseContiune = true;
                    }
                }
                else if (employeeSalaryResponseNumber!=1 && employeeSalaryResponseNumber!=2)
                {
                   
                    Console.WriteLine(warningMessage.wrongValueMessage);
                    Console.WriteLine("Bəli(1) / Xeyr(2)");
                    isSalaryResponseContiune = false;
                }
            } while (!isSalaryResponseContiune);
          
            Console.WriteLine();
            Console.WriteLine(warningMessage.enterMartialStatusMessage);
            int maritalStatusResponse;
            string martialStatus;
            bool isMartialContiune = false;
            do
            {
                Console.WriteLine("Evli (1) / Subay (2) / Dul (3)");
                Console.Write(warningMessage.enterMessage);
                martialStatus = Console.ReadLine();
                while (!int.TryParse(martialStatus, out maritalStatusResponse))
                {
                    if (string.IsNullOrWhiteSpace(martialStatus))
                    {
                        Console.WriteLine(warningMessage.emptyValueMessage);
                    }
                    if (!string.IsNullOrWhiteSpace(martialStatus))
                    {
                        if (martialStatus.GetType() == typeof(string))
                        {
                            Console.WriteLine(warningMessage.wrongLetterMessage);
                        }
                    }
                    Console.WriteLine(warningMessage.wrongMaritalStatusMessage);
                    Console.WriteLine(warningMessage.enterMessage);
                    martialStatus = Console.ReadLine();
                }
                isMartialContiune = true;
                if (maritalStatusResponse!=1&&maritalStatusResponse!=2&&maritalStatusResponse!=2)
                {
                    isMartialContiune = false;
                    Console.WriteLine(warningMessage.wrongValueMessage);
                    
                }
            } while (!isMartialContiune);
            Console.WriteLine();
            Console.WriteLine(warningMessage.confirmationMartialStatusMessage);
            int martialStatusConfidenceResponseNumber;
            bool isConfidenceMartialContiune = false;
            do
            {
                Console.Write(warningMessage.enterMessage);
                string martialStatusConfidenceResponse = Console.ReadLine();
                while (!int.TryParse(martialStatusConfidenceResponse, out martialStatusConfidenceResponseNumber))
                {
                    if (string.IsNullOrWhiteSpace(martialStatusConfidenceResponse))
                    {
                        Console.WriteLine(warningMessage.emptyValueMessage);
                    }
                    if (!string.IsNullOrWhiteSpace(martialStatusConfidenceResponse))
                    {
                        if (martialStatusConfidenceResponse.GetType() == typeof(string))
                        {
                            Console.WriteLine(warningMessage.wrongLetterMessage);
                        }
                    }
                    Console.WriteLine(warningMessage.wrongValueMessage);
                    Console.Write(warningMessage.enterMessage);
                    martialStatusConfidenceResponse = Console.ReadLine();
                }
                isConfidenceMartialContiune = true;
                if (martialStatusConfidenceResponseNumber!=1&&maritalStatusResponse!=2)
                {
                    Console.WriteLine(warningMessage.wrongValueMessage);
                    isConfidenceMartialContiune = false;
                }
            } while (!isConfidenceMartialContiune);
           
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
                string haveChildResponse;
                bool haveChildContiune = false;
                do
                {
                    Console.Write(warningMessage.enterMessage);
                    haveChildResponse = Console.ReadLine();
                    while (!int.TryParse(haveChildResponse, out childResponseConfiderinceNumber))
                    {
                        if (string.IsNullOrWhiteSpace(haveChildResponse))
                        {
                            Console.WriteLine(warningMessage.emptyValueMessage);
                        }
                        if (!string.IsNullOrWhiteSpace(haveChildResponse))
                        {
                            if (haveChildResponse.GetType() == typeof(string))
                            {
                                Console.WriteLine(warningMessage.wrongLetterMessage);
                            }
                        }
                        Console.WriteLine(warningMessage.wrongValueMessage);
                        Console.Write(warningMessage.enterMessage);
                        haveChildResponse = Console.ReadLine();
                    }
                    haveChildContiune = true;
                    if (childResponseConfiderinceNumber!=1&&childResponseConfiderinceNumber!= 2)
                    {
                        Console.WriteLine(warningMessage.wrongValueMessage);
                        haveChildContiune = false;
                    }
                } while (!haveChildContiune);
               
                if (childResponseConfiderinceNumber == 1)
                {
                    Console.WriteLine();
                    Console.Write(warningMessage.enterChildCountMessage);
                    string childCountResponse = Console.ReadLine();
                    while (!int.TryParse(childCountResponse,out childCount))
                    {
                        if (string.IsNullOrWhiteSpace(childCountResponse))
                        {
                            Console.WriteLine(warningMessage.emptyValueMessage);
                        }
                        if (!string.IsNullOrWhiteSpace(childCountResponse))
                        {
                            if (childCountResponse.GetType() == typeof(string))
                            {
                                Console.WriteLine(warningMessage.wrongLetterMessage);
                            }
                        }
                        Console.WriteLine(warningMessage.wrongChildCountMessage);
                        Console.Write(warningMessage.enterMessage);
                        childCountResponse = Console.ReadLine();
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
                Console.Write(warningMessage.enterMessage);
                string disabilityStatus = Console.ReadLine();
                while (!int.TryParse(disabilityStatus, out disabilityStatusNumber))
                {
                    if (string.IsNullOrWhiteSpace(disabilityStatus))
                    {
                        Console.WriteLine(warningMessage.emptyValueMessage);
                    }
                    if (!string.IsNullOrWhiteSpace(disabilityStatus))
                    {
                        if (disabilityStatus.GetType() == typeof(string))
                        {
                            Console.WriteLine(warningMessage.wrongLetterMessage);
                        }
                    }
                    Console.WriteLine(warningMessage.wrongValueMessage);
                    Console.Write(warningMessage.enterMessage);
                    disabilityStatus = Console.ReadLine();
                }
                if (disabilityStatusNumber == 1)
                {
                    isContunie = true;
                    const float divisor = 2f;
                    if (salary <= 1000)
                    {
                        interest = 15 / divisor;
                        taxInterest = (salary / (float)100) * interest;
                        fixSalary=Math.Round(salary - taxInterest,2);
                    }
                    if (salary > 1000 && salary <= 2000)
                    {
                        interest = 20 / divisor;
                        taxInterest = (salary / (float)100) * interest;
                        fixSalary = Math.Round(salary - taxInterest, 2);
                    }
                    if (salary > 2000 && salary <= 3000)
                    {
                        interest = 25 / divisor;
                        taxInterest = (salary / (float)100) * interest;
                        fixSalary=Math.Round(salary - taxInterest,2);
                    }
                    if (salary > 3000)
                    {
                        interest = 30 / divisor;
                        taxInterest = ((salary / (float)100) * interest);
                        fixSalary=Math.Round(salary - taxInterest,2);

                    }
                }
                else if (disabilityStatusNumber == 2)
                {
                    isContunie = true;
                    if (salary <= 1000)
                    {
                        interest = 15;
                        taxInterest = (salary / 100) * interest;
                        fixSalary = salary - taxInterest;
                    }
                    if (salary > 1000 && salary <= 2000)
                    {
                        interest = 20;
                        taxInterest = (salary / 100) * interest;
                        fixSalary = salary - taxInterest;
                    }
                    if (salary > 2000 && salary <= 3000)
                    {
                        interest = 25;
                        taxInterest = (salary / 100) * interest;
                        fixSalary = salary - taxInterest;
                    }
                    if (salary > 3000)
                    {
                        interest = 30;
                        taxInterest = (salary / 100) * interest;
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
            table.AddRow(marriedPayment, payment,interest+ " %",Math.Round(taxInterest,2), salary, fixSalary);
            table.Write();
            Console.WriteLine("**Sizin əmək haqqınız bu pul vahidləri ilə ödəniləcək**");
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
                    moneyTable.Write();
                    //Console.WriteLine("{0} eded {1} manat çıxarıldı", moneyUnitCount, monetaryUnits[i]);
                }
                salary = salary - (moneyUnitCount * monetaryUnits[i]);
            }
        }
    }
}
