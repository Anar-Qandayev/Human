using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Student : Person
    {
        public int IQRank { get; set; } /*IQ imtahanının nəticəsi 100 bal üzərindən*/
        public int LanguageRank { get; set; } /*Dil imtahanının nəticəsi (100 bal üzərindən)*/
        public Student(int IQRank , int LanguageRank):base()
        {
            this.IQRank = IQRank;
            this.LanguageRank = LanguageRank;
        }

        public Student(): base()
        {
        }

        

        //Şagirdin iki imtahanının nəticəsi 120dən azdırsa, o zaman sinifdə qaldığı mənasını bildirən methoddur.
        public void ExamResult(/*int IQRank , int LanguageRank*/int v, int v1)
        {
            int Great = IQRank + LanguageRank;
            if (Great>=120)
            {
                Console.WriteLine($"siz imtahandan {Great} bal toplamisiz." );
            }
            else
            {
                Console.WriteLine("Siz kechid bali toplaya bilmesiz. Teesufki sinifde qaldiniz ");
            }

        }
    }
}
