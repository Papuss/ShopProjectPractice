using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    class Elelmiszer
    {
        protected long vonalkod;
        protected string gyarto;
        protected DateTime szavatossagiIdo;

        public Elelmiszer(long vonalkod, string gyarto, DateTime szavatossagiIdo)
        {
            this.vonalkod = vonalkod;
            this.gyarto = gyarto;
            this.szavatossagiIdo = szavatossagiIdo;
        }

        public long getVonalkod()
        {
            return vonalkod;
        }

        public bool joMeg()
        {
            if (szavatossagiIdo > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getGyarto()
        {
            return gyarto;
        }

        public DateTime getSzavatossagiIdo()
        {
            return szavatossagiIdo;
        }

        public override string ToString()
        {
            return new string((vonalkod + ", " + gyarto + ", " + szavatossagiIdo.ToString()).ToCharArray().ToArray());
        }
    }
}
