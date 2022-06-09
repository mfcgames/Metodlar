using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class SepetManager
    {
        //Naming Convention-İsimlendirme Kuralı...
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : "+urun.Name);
        }

        public void Ekle2(string adi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler Eklendi! : "+adi,fiyat);
        }
    }
}
