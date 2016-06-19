using System.Collections.Generic;

namespace SurfaceMoistureLib
{
    /// <summary>
    /// Mérési helyekkel kapcsolatos utasításkészlet
    /// </summary>
    public class MeasuringLocationManager
    {
        public List<MeasuringLocation> Locations = new List<MeasuringLocation>();

        /// <summary>
        /// Új mérési hely felvétele
        /// </summary>
        /// <param name="x">X koordináta</param>
        /// <param name="y">Y koordináta</param>
        /// <param name="measuringpointHeights">Mérési magasságokhoz tartozó palettaazonosítók</param>
        public void AddLocation(float x, float y, int[] measuringpointHeights)
        {
            MeasuringLocation loc = new MeasuringLocation(measuringpointHeights);
            loc.CordX = x;
            loc.CordY = y;
            Locations.Add(loc);
        }

        //TODO kell egy DeletePoint függvény
        //TODO kelle gy MovePoint, ami átírja a koordinátáját
    }
}
