using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
     class Tej : Elelmiszer
    {
        private long vonalkod;

        public readonly int LITER;
        public readonly int FELLITER;
        public readonly int POHAR;
        public readonly double ZSIROS;
        public readonly double FELZSIROS;


        protected int urtartalom;
        protected string gyarto;
        protected DateTime szavatossagiIdo;
        protected double zsirtartalom;
        protected long ar;

        public Tej(long vonalkod, int urtartalom, string gyarto, DateTime szavatossagiIdo, double zsirtartalom, long ar)
            : base(vonalkod, gyarto, szavatossagiIdo)
        {
            this.vonalkod = vonalkod;
            this.urtartalom = urtartalom;
            this.gyarto = gyarto;
            this.szavatossagiIdo = szavatossagiIdo;
            this.zsirtartalom = zsirtartalom;
            this.ar = ar;
        }
        


        public Boolean joMeg(DateTime szavatossagiIdo)
        {
            if(szavatossagiIdo > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

        public int getUrtartalom()
        {
            return urtartalom;
        }

        public double getZsirtartalom()
        {
            return zsirtartalom;
        }

        public long getAr()
        {
            return ar;
        }

        
        public override string ToString()
        {
            return new string((urtartalom.ToString() + ", "+ gyarto + ", "+ szavatossagiIdo.ToString() + ", "+
                zsirtartalom.ToString() + ", "+ ar.ToString()).ToCharArray().ToArray());
        }

    }
}
