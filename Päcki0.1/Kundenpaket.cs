using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päcki0._1
{
    class Kundenpaket : Paket
    {

        public Kundenpaket(int länge, int breite, int höhe, int gewicht)
        {
            this.Lenght = länge;
            this.Width = breite;
            this.Height = höhe;
            this.Weight = gewicht;
            this.Weight = länge*höhe*breite;

        }
    }
}
