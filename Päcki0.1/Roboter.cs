using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päcki0._1
{
    class Roboter
    {
        public List<Paket> PaketListe { get; set; }
        
        public Roboter()
        {
            PaketListe = new List<Paket>();
            PaketListe.Add(new PaketS());
            PaketListe.Add(new PaketM());
            PaketListe.Add(new PaketExtra());

        }



    }
}
 