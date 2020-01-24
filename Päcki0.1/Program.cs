using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päcki0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kundenpaket kundenpaket = new Kundenpaket(15, 11, 1, 1);
            Roboter päcky = new Roboter();

            Console.WriteLine(päcky.PaketListe[0].MaxHeight); 



            Console.ReadLine();
        }
    }
}
