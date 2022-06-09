using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem toplama = new DortIslem();
            bool toplam = true;
            while (toplam)
            {
                toplama.Topla(0, 0);
                //toplam = false;
            }
        }
    }
}
