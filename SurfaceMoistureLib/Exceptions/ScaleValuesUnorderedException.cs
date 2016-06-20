using System;

namespace SurfaceMoistureLib.Exceptions
{
    public class ScaleValuesUnorderedException : Exception
    {
        //2016.06.17 Kanyó: az int[] helyett lehetne IEnumerable<int> is (ősosztály), 
        //mert csak annyit használsz belőle, hogy bejárható legyen
        public ScaleValuesUnorderedException(int[] scaleValues)
            : base(string.Format("A megadott skálaértékek nem szigorúan monoton növekvők: {0} ",string.Join(",",scaleValues)))
        {
        }
    }
}
