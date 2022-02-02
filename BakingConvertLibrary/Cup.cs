using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingConvertLibrary
{
    public class Cup : IConvert
    {
        public double cup;
        public double Convert(double deciliter)
        {
            return deciliter * 0.4; 
        }
    }
}
