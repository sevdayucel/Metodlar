using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention isimlendirme kuralı
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi" + urun.Adi);
        
        }
        public void Ekle2(string Adi, string Aciklama, double Fiyati, int stokAdedi)
        {
            Console.WriteLine("tebrikler sepete eklendi");
        
        }

    }
}
