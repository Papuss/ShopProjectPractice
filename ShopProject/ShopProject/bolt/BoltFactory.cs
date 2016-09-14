using System;
using ShopProject.bolt.aruk;
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



        public Sajt ujSajt(long vonalkod, string gyarto, DateTime szavatossagiIdo)
        {
            return new Sajt(vonalkod, gyarto, szavatossagiIdo);
        }
        
        public Szappan ujSzappan(long vonalkod, string gyarto)
        {
            return new Szappan(vonalkod, gyarto);
        }

    }
}
