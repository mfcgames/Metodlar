using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            sayi1 = int.Parse(Console.ReadLine());
            sayi2=int.Parse(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam Sonucu : "+toplam);
        }
    }
}
