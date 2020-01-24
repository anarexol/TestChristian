using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päcki0._1
{
    class PaketS : Paket
    {
        public PaketS()
        {
            this.MinLenght = 15;
            this.MinWidth = 11;
            this.MinHeight = 1;
    
            this.MaxLenght = 35;
            this.MaxWidth = 25;
            this.MaxHeight = 10;

            this.MaxWeight = 2;
        }
    }
}
