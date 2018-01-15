using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    class Noiz
    {
        int range;
        Random r;
        public Noiz(int range)
        {
            this.range = range;
            r = new Random();
        }
        public int DoTheThing(int x)
        {
             
            double wsp = r.NextDouble() * range / 100;
            double znak = r.NextDouble() - 0.45;
            int ret;
            if (znak > 0)
                ret = (int)(x * wsp);
            else
                ret = (int)-(x * wsp);
            ret = x + ret;
            if (ret > 255)
                ret = 255;
            if (ret < 11)
                ret = 11;
            return ret;
        }
    }
}
