using System;

namespace emek_haqqi_komekcisi_app
{
    public class WarningMessage
    {
        public string emptyValueMessage = "Boş dəyər daxil etmisiz !";

        public string enterMessage = "Daxil et: ";

        public string wrongLetterMessage = "Daxil edilmiş dəyərin terkibində hərf ola bilməz !";

        public string enterSalaryMessage = "Əmək haqqını daxil edin : ";

        public string wrongValueMessage = "Zəhmət olmasa duzgun dəyər daxil edin!";

        public string wrongSalaryMessage = "Zəhmət olmasa əmək haqqını düzgün daxil edin!";

        public string confirmationSalaryMessage = "Əmək haqqını duzgun daxil etmisiz ? Bəli(1) / Xeyr(2)";

        public string enterMartialStatusMessage = "Zəhmət olmasa ailə vəziyyəti ilə bağlı aşağıdakı seçimlərdən özünüzə uğun halı daxil edin :";

        public string wrongMaritalStatusMessage = "Zəhmət olmasa ailə vəziyyəti məlumatinizi duzgun daxil edin";

        public string confirmationMartialStatusMessage = "Ailə vəziyyətinizi düzgün daxil etmisiz ? Bəli(1) / Xeyr(2)";

        public string confirmationDoHaveChildMessage = "Uşağınız varmı ? Bəli(1) / Xeyir(2)";

        public string enterChildCountMessage = "Zehmet olmasa uşaqların sayın qeyd edin :";

        public string successfulMessage = "Proses uğurla davam edir";

        public string wrongChildCountMessage = "Zəhmət olmasa uşaq sayını düzgün daxil edin !";

        public string disabilityMessage = "Əlilik statusunuz var ? Bəli (1) / Xeyr (2)";
        public void childPaymentMessage(int payment)
        {
            Console.WriteLine($"Uşaq sayına görə {payment} AZN ödəniş edildi");
        }
    }
}
