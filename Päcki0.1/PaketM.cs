using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päcki0._1
{
    class PaketM : Paket
    {
        public PaketM()
        {
            this.MinLenght = 15;
            this.MinWidth = 11;
            this.MinHeight = 1;

            this.MaxLenght = 60;
            this.MaxWidth = 30;
            this.MaxHeight = 15;

            this.MaxWeight = 2;
        }
    }
}
