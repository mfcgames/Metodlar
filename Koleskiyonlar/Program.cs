﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleskiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "engin","murat","kerem","halil"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("İlker");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
        }
    }
}
