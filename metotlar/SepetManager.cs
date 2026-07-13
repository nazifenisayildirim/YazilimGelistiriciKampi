using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi");

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int StokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urunAdi);
            Console.WriteLine("Fiyatı : " + fiyat);
            Console.WriteLine("Açıklama : " + aciklama);
        }
    }
}
