using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuvenliAlimSatim.Business
{
    public class SendReference
    {
        public int Reference()
        {
            Random random = new Random();
            int reference = random.Next(100000, 1000000);
            return reference;
        }
    }
}
