using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceMoistureLib.Exceptions
{
    public class ScaleValueOutOfRangeException : Exception
    {
        public ScaleValueOutOfRangeException(int value, int max)
            //meghívom az ősosztály konstruktorát (stringet vár, ez lesz a message)
            : base(string.Format("A megadott skálaérték ({0}) a megengedett tartományon kívül esik (0-{1})",value, max)) 
        {
        }
    }
}
