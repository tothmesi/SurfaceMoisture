using System;
using System.Collections.Generic;

namespace SurfaceMoistureLib
{
    /// <summary>
    /// Egy mintavételi hely a hozzá tartozó mérési pontokkal
    /// </summary>
    public class MeasuringLocation
    {
        public readonly int Id;
        public string Description;
        public float CordX;
        public float CordY;
        public readonly List<MeasuringPoint> MeasuringPoints = new List<MeasuringPoint>();

        /// <summary>
        /// Beállítja a mérési pontok értékeit
        /// </summary>
        /// <param name="measuringHeights">Mérési magasságokhoz tartozó palettaazonosítók</param>
        public MeasuringLocation(int[] measuringHeights)
        {
            //TODO 2016.06.19 Kanyó: azonosítót kreálni neki

            //TODO 2016.06.19 Kanyó: hozzáadni annyi új mérési pontot a megadott paletta azonosítóval, amennyi kell
            throw new NotImplementedException();
        }

        
    }
}
