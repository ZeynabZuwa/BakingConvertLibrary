using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingConvertLibrary
{
    public class Deciliter:IConvert
    {
        public double deciliter;

        public double Convert(double cup)
        {
            return cup / 2.4;
        }
    }
}
