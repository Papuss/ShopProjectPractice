using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    class TartosTej : Tej
    {
        public TartosTej(long vonalkod, int urtartalom, string gyarto, DateTime szavatossagiIdo, double zsirtartalom, long ar) : 
            base(vonalkod,urtartalom,gyarto,szavatossagiIdo,zsirtartalom,ar)
        {
           
        }
    }
}
