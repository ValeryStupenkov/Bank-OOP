using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_OOP.Classes
{
    class NormalRandom
    {
        public NormalRandom() { }

        public double NextDouble()
        {
            Random rand = new Random(); //reuse this if you are generating many
            double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - rand.NextDouble();
            var p1 = Math.Sqrt((-2.0) * Math.Log(u1));
            var sinArg = 2.0 * Math.PI * u2;
            var p2 = Math.Sin(sinArg);
            double randStdNormal = Math.Abs(p1 * p2); //random normal(0,1)
            return randStdNormal;
        }
        
    }
}
