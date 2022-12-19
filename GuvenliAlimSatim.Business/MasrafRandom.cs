using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuvenliAlimSatim.Business
{
    public class MasrafRandom
    {
        public double Masraf()
        {
            Random random = new Random();
            Random random2 = new Random();
            var carpım = random2.Next(10, 20);
            var masraf = random.NextDouble()*carpım;
            return masraf;
        }
    }
}
