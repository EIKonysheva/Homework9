using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            ACipher c1 = new ACipher();
            Console.WriteLine("Закодируем шифром 1");
            c1.encode();
            Console.WriteLine("Раскодируем шифр 1");
            c1.decode();
            BCipher c2 = new BCipher();
            Console.WriteLine("Закодируем шифром 2");
            c2.encode();
            Console.WriteLine("Раскодируем шифр 2");           
            c2.decode();
            Point point = new Point("red", "visible");
             
        }
    }
}
