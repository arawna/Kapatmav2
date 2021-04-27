using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapatmav2
{
    class Kapatma
    {
        public void kapat()
        {
            Console.Write("Kapatma süresi giriniz(dk): ");
            int sure = Convert.ToInt32(Console.ReadLine()) * 60;

            System.Diagnostics.Process.Start("shutdown", "-f -f -f " + sure);

            Console.WriteLine("---------------");
            Console.WriteLine("Bilgisayarınız " + sure/60 + " dakika sonra kapatılacak.");
            Console.Write("---------------");
            Console.ReadLine();
        }
    }
}
