using System;

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
            // Əmək haqqini daxil edilməsi bolməsi :
            Console.Write("Əmək haqqını daxil edin : ");
            int salary; // Əmək haqqi
            string employeeSalary = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(employeeSalary))
            {
                Console.WriteLine(warningMessage.emptyValueMessage);
            }
            //salary= EmployeeSalary(employeeSalary);
            while (!int.TryParse(employeeSalary, out salary))
            {
                Console.WriteLine(warningMessage.wrongSalaryMessage);
                Console.Write("Əmək haqqını daxil edin :");
                employeeSalary = Console.ReadLine();
            }
            // end=========================================================================================================================================

            // Əmək haqiinin duzgun daxil ediblib edilmemesini  yoxlanisi
            Console.WriteLine(warningMessage.confirmationMessage);
            Console.Write("Daxit et: ");
            string employeeSalaryConfidenceResponse = Console.ReadLine();
            int employeeSalaryResponseNumber;
            while (!int.TryParse(employeeSalaryConfidenceResponse,out employeeSalaryResponseNumber))
            {
                Console.WriteLine(warningMessage.wrongValueMessage);
                Console.WriteLine("*Bəli(1) / *Xeyr(2)");
                employeeSalaryConfidenceResponse = Console.ReadLine();
            }
            if (employeeSalaryResponseNumber!=1)
            {
                Console.Write("Əmək haqqını daxil edin:");
                while (!int.TryParse(employeeSalary, out salary))
                {
                    Console.WriteLine(warningMessage.wrongSalaryMessage);
                    Console.Write("Əmək haqqını daxil edin :");
                    employeeSalary = Console.ReadLine();
                }
            }
            //end============================================================================================================================================

            Console.WriteLine();
            Console.WriteLine("Zəhmət olmasa ailə vəziyyəti ilə bağlı aşağıdakı seçimlərdən özünüzə uğun halı daxil edin :");
            Console.WriteLine("Evli (1) * Subay (2) * Dul (3)");
            Console.WriteLine("Daxil et: ");
            int maritalStatusResponse;//Aile veziyyeti
            string martialStatus = Console.ReadLine();
            while (!int.TryParse(martialStatus, out maritalStatusResponse))
            {
                Console.WriteLine(warningMessage.wrongMaritalStatusMessage);
                martialStatus = Console.ReadLine();
            }
            Console.WriteLine(warningMessage.confirmationMessage);
            string martialStatusConfidenceResponse = Console.ReadLine();///Aile veziyyeti tesdiq
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
                    Console.WriteLine("*Bəli(1) / *Xeyr(2)");
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
           
           
            int payment = 0;
            if (maritalStatusResponse==1 || maritalStatusResponse==3)
            {
                if (maritalStatusResponse==1)
                {
                    salary += 50;
                }
                Console.WriteLine("Uşağınız varmı ?");
                string haveChildResponse = Console.ReadLine();//usaq sorgusu
                if (haveChildResponse=="he")
                {
                    Console.Write("Zehmet olmasa uşaqların sayın qeyd edin :");
                    int childCount = Convert.ToInt32(Console.ReadLine());
                  //usaq odenisi
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
                        warningMessage.childPaymentMessage(payment);g
                    }
                }
            }
            Console.WriteLine("Əlilik statusunuz var ?");
            string disabilityStatus = Console.ReadLine();
            double taxInterest=0;//gelir vergisinin meblegi
            double fixSalary=0; // xalis emek haqqi
          
            if (disabilityStatus=="beli")
            {
                float interest = 0;
                const float divisor = 2f;
                float a = 100;
                if (salary <= 1000)
                {
                    interest = 15;
                    taxInterest =(salary / a) * (interest / divisor);
                    fixSalary = salary - taxInterest;
                }
                if (salary > 1000 && salary <= 2000)
                {
                    interest = 20;
                    taxInterest = Convert.ToInt32((salary / 100) * (interest / divisor));
                    fixSalary = salary - taxInterest;
                }
                if (salary > 2000 && salary <= 3000)
                {
                    interest = 25;
                    taxInterest = Convert.ToInt32((salary / 100) * (interest / divisor));
                    fixSalary = salary - taxInterest;
                }
                if (salary > 3000)
                {
                    interest = 30;
                    taxInterest = Convert.ToInt32((salary / 100) * (interest / divisor));
                    fixSalary = salary - taxInterest;
                }
          
            }
          
            if(disabilityStatus=="xeyr")
            {
                if (salary<=1000)
                {

                    taxInterest=(salary / 100) * 15;
                    fixSalary = salary - taxInterest;
                }
                if (salary>1000&&salary<=2000)
                {
                    taxInterest = (salary / 100) * 20;
                    fixSalary = salary - taxInterest;
                }
                if (salary>2000&&salary<=3000)
                {
                    taxInterest = (salary / 100) * 25;
                    fixSalary = salary - taxInterest;
                }
                if (salary>3000)
                {
                    taxInterest = (salary / 100) * 30;
                    fixSalary = salary - taxInterest;
                }
            }



            //➢ ailə müavinəti - 50 azn 
            //➢ uşaq pulu  - sayina gore
            Console.WriteLine(payment);
            //➢ gəlir vergisi dərəcəsi - umumi gelire gore hesablam faizin cixilmasi
            //➢ gəlir vergisinin məbləği - faizde tutulub
            Console.WriteLine(taxInterest);
            //➢ ümumi əmək haqqı - umumi emek haqqi ?
            Console.WriteLine(salary);
            //➢ xalis əmək haqqı - xalis emek haqqi da tutulub.
            Console.WriteLine(fixSalary);

            //paymentTerminal(fixSalary);




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
        public static void paymentTerminal(int salary)
        {
            int[] monetaryUnits = { 200, 100, 50, 20, 10, 5, 1 };
            int twoHundredBanknoteCount = 0;
            int hundredBanknoteCount = 0;
            int fiftyBanknoteCount = 0;
            int twentyBanknoteCount = 0;
            int tenBanknoteCount = 0;
            int fiveBanknoteCount = 0;
            int oneBanknoteCount = 0;

            for (int i = 0; i < monetaryUnits.Length; i++)
            {
                twoHundredBanknoteCount = salary / monetaryUnits[0];
                int result1 = salary - twoHundredBanknoteCount * monetaryUnits[0];
                hundredBanknoteCount = result1 / monetaryUnits[1];
                int result2 = result1 - hundredBanknoteCount * monetaryUnits[1];
                fiftyBanknoteCount = result2 / monetaryUnits[2];
                int result3 = result2 - fiftyBanknoteCount * monetaryUnits[2];
                twentyBanknoteCount = result3 / monetaryUnits[3];
                int result4 = result3 - twentyBanknoteCount * monetaryUnits[3];
                tenBanknoteCount = result4 / monetaryUnits[4];
                int result5 = result4 - tenBanknoteCount * monetaryUnits[4];
                fiveBanknoteCount = result5 / monetaryUnits[5];
                int result6 = result5 - fiveBanknoteCount * monetaryUnits[5];
                oneBanknoteCount = result6 / monetaryUnits[6];
            }

            Console.WriteLine("{0} eded 200 manat", twoHundredBanknoteCount);
            Console.WriteLine("{0} eded 100 manat", hundredBanknoteCount);
            Console.WriteLine("{0} eded 50 manat", fiftyBanknoteCount);
            Console.WriteLine("{0} eded 20 manat", twentyBanknoteCount);
            Console.WriteLine("{0} eded 10 manat", tenBanknoteCount);
            Console.WriteLine("{0} eded 5 manat", fiveBanknoteCount);
            Console.WriteLine("{0} eded 1 manat", oneBanknoteCount);
        }
    }
}
