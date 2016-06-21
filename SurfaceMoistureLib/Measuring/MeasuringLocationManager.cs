using System;
using System.Collections.Generic;
using System.Linq;

namespace SurfaceMoistureLib
{
    /// <summary>
    /// Mérési helyekkel kapcsolatos utasításkészlet
    /// </summary>
    public class MeasuringLocationManager
    {
        public static int LocationIdCounter = 1;
        public List<MeasuringLocation> Locations = new List<MeasuringLocation>();

        /// <summary>
        /// Mintavételi hely felvétele
        /// </summary>
        /// <param name="x">X koordináta</param>
        /// <param name="y">Y koordináta</param>
        /// <param name="paletteIds">Mérési magasságokhoz tartozó azonosítók</param>
        public void AddLocation(float x, float y, int paletteId, int measuringPointCount)
        {
            MeasuringLocation loc = new MeasuringLocation(paletteId, measuringPointCount, LocationIdCounter++);
            loc.CordX = x;
            loc.CordY = y;
            Locations.Add(loc);
        }

        /// <summary>
        /// Mintavételi helyet jelöl
        /// </summary>
        /// <param name="id">Mintavételi hely Id-ja</param>
        public void DeleteLocation(int id)
        {
            //Szűröm a listát: 
            //vagy visszaad egy MeasuringLocation-t, vagy nullt (SingleOrDefault - ha érvénytelen az id, nullt ad)
            MeasuringLocation loc = Locations.Where(x => x.Id == id).SingleOrDefault();
            if (loc == null)
                return;
            Locations.Remove(loc);

            //Törölt elem id-jától kezdve mindegyik id-t eggyel csökkenti és IdCounter--
            foreach (MeasuringLocation x in Locations)
            {
                if (x.Id > id)
                    x.Id--;
            }
            //ugyanez: Locations.ForEach(x => { if (x.Id > id) x.Id--; });
            LocationIdCounter--;
        }

        public void InsertLocation()
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
