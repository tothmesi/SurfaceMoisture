using System.Collections.Generic;

namespace SurfaceMoistureLib
{
    /// <summary>
    /// Egy mintavételi hely a hozzá tartozó mérési pontokkal
    /// </summary>
    public class MeasuringLocation
    {
        public int Id;
        //még nem tudom, a koordinátákat hogyan tárolom, de kell majd rá egy osztály
        
        public List<MeasuringPoint> MeasuringPoints = new List<MeasuringPoint>();

        public void SetPoints ()
        {
            
        }

        
    }
}
