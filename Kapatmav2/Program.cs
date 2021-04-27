using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapatmav2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kapatma kapatma = new Kapatma();
            baslangıc:
            try
            {
                kapatma.kapat();
            }
            catch
            {
                Console.WriteLine("Sadece sayı giriniz!");
                goto baslangıc;
            }
        }
    }
    
}
