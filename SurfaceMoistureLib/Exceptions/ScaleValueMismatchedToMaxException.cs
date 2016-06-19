using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceMoistureLib.Exceptions
{
    public class ScaleValueMismatchedToMaxException : Exception
    {
        public ScaleValueMismatchedToMaxException(int value, int max)
            : base(string.Format("A legnagyobb felső határ ({0}) nem egyezik meg a műszer mérési maximumával ({1})",value, max))
        {
        }
    }
}
