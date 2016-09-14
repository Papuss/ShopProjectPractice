using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.bolt
{
    class BoltFactory
    {

        public Tej ujTartosTej(long vonalkod, int urtartalom, string gyarto, DateTime szavatossagiIdo, double zsirtartalom,long ar)
        {
            return new Tej(vonalkod, urtartalom, gyarto, szavatossagiIdo, zsirtartalom, ar);
        }

        public Tej ujFeltartosTej(long vonalkod, int urtartalom, string gyarto, DateTime szavatossagiIdo, double zsirtartalom, long ar)
        {
            return new Tej(vonalkod, urtartalom, gyarto, szavatossagiIdo, zsirtartalom, ar);
        }

        

    }
}
