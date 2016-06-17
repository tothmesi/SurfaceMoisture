using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceMoistureLib
{
    public class Interval
    {
        /// <summary>
        /// Az intervallum kezdete a műszer saját skálája alapján
        /// </summary>
        public int From;

        /// <summary>
        /// Az intervallum vége a műszer saját skálája alapján
        /// </summary>
        public int To;

        public CategoryType Type;

        public override string ToString()
        {
            return string.Format("Intervallum: [{0} - {1}], {2}", From, To, Type);
        }

        public bool IsInInterval(int value)
        {
            return (From <= value && value < To);
        }

    }
}
