using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulagailua
{
    internal class Kalkulagailua
    {
        public float Zbk1 { get; set; }
        public float Zbk2 { get; set; }

        public Kalkulagailua()
        {
            this.Zbk1 = 0;
            this.Zbk2 = 0;
        }

        public Kalkulagailua(float zbk1, float zbk2)
        {
            this.Zbk1 = zbk1;
            this.Zbk2 = zbk2;
        }

        public float Gehiketa()
        {
            return this.Zbk1 + this.Zbk2;
        }
        public float Kenketa()
        {
            return this.Zbk1 - this.Zbk2;
        }

        public float Biderketa()
        {
            return this.Zbk1 * this.Zbk2;
        }

        public float Zatiketa()
        {
            return this.Zbk1 / this.Zbk2;
        }

    }
}
