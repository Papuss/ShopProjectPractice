using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.bolt.aruk
{
    class Sajt : Elelmiszer
    {
        private long vonalkod;
        private string gyarto;
        private DateTime szavatossagiIdo;

        public Sajt(long vonalkod, string gyarto, DateTime szavatossagiIdo) : base(vonalkod,gyarto,szavatossagiIdo)
        {
            this.vonalkod = vonalkod;
            this.gyarto = gyarto;
            this.szavatossagiIdo = szavatossagiIdo;
        }

        protected long Vonalkod1
        {
            get
            {
                return vonalkod;
            }

            set
            {
                vonalkod = value;
            }
        }

        protected string Gyarto
        {
            get
            {
                return gyarto;
            }

            set
            {
                gyarto = value;
            }
        }

        protected DateTime SzavatossagiIdo
        {
            get
            {
                return szavatossagiIdo;
            }

            set
            {
                szavatossagiIdo = value;
            }
        }

       
    }
}
