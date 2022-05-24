using System;

namespace emek_haqqi_komekcisi_app
{
    public class WarningMessage
    {
        public string emptyValueMessage = "Boş dəyər daxil etmisiz !";
        public string wrongValueMessage = "Zəhmət olmasa duzgun dəyər daxil edin!";
        public string wrongSalaryMessage = "Zəhmət olmasa əmək haqqını düzgün daxil edin!";
        public string confirmationMessage = "Əmək haqqını duzgun daxil etmisiz ? *Bəli(1) / *Xeyr(2)";
        public string wrongMaritalStatusMessage = "Zəhmət olmasa ailə vəziyyəti məlumatinizi duzgun daxil edin";
        public string successfulMessage = "Proses uğurla davam edir";

        public void childPaymentMessage(int payment)
        {
            Console.WriteLine($"Uşaq sayına görə {payment} AZN ödəniş edildi");
        }
    }
}
