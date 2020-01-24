using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päcki0._1
{
    class PaketExtra : Paket
    {
        public PaketExtra()
        {
            this.MinLenght = 15;
            this.MinWidth = 11;
            this.MinHeight = 1;

            this.MaxLenght = 35;
            this.MaxWidth = 25;
            this.MaxHeight = 10;
            this.MaxKubik = 150;

            this.MaxWeight = 100;
        }
    }
}
