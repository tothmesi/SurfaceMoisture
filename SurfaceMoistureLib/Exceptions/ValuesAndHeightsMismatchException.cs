using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceMoistureLib.Exceptions
{
    //Ez az osztály lehet, hogy nem fog kelleni
    class ValuesAndHeightsMismatchException : Exception
    {
        public ValuesAndHeightsMismatchException(int[] heights, int[] values)
            : base(string.Format("A megadott magassági pontok száma ({0}) nem egyezik a mért értékek számával ({1})", heights.Length, values.Length))
        {
        }
    }
}
