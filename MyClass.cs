using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LatestLangFeatures
{
    public struct Coordinates
    {

        internal Coordinates(Double x , Double y )
            //Defining  a Parametrised constructor is must 
        {
            X = x;
            Y = y;
        }


        public double X { get; }
        public double Y { get; }
    }

    
}
