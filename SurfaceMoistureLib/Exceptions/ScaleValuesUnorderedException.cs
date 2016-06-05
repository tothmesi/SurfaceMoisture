using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceMoistureLib.Exceptions
{
    public class ScaleValuesUnorderedException : Exception
    {
        public ScaleValuesUnorderedException(int[] scaleValues)
            : base(string.Format("A megadott skálaértékek nem szigorúan monoton növekvők: {0} ",string.Join(",",scaleValues)))
        {
        }


    }
}
