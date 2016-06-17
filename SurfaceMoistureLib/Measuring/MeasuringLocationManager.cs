﻿using System.Collections.Generic;

namespace SurfaceMoistureLib
{
    /// <summary>
    /// Mérési helyekkel kapcsolatos utasításkészlet
    /// </summary>
    public class MeasuringLocationManager
    {
        public List<MeasuringLocation> Locations = new List<MeasuringLocation>();

        //TODO kell egy AddPoint függvény, ami példányosít egy Measuring Pointot
        //TODO kell egy DeletePoint függvény
        //TODO kelle gy MovePoint, ami átírja a koordinátáját
    }
}
