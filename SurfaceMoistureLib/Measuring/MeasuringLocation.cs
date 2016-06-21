using SurfaceMoistureLib.Exceptions;
using System;
using System.Collections.Generic;

namespace SurfaceMoistureLib
{
    
    /// <summary>
    /// Egy mintavételi hely a hozzá tartozó mérési pontokkal
    /// </summary>
    public class MeasuringLocation
    {
        public int Id;
        public string Description;
        public float CordX;
        public float CordY;
        public readonly List<MeasuringPoint> MeasuringPoints = new List<MeasuringPoint>();

        /// <summary>
        /// Létrehozza a mérési pontokat
        /// </summary>
        /// <param name="paletteId">Default palettaId</param>
        /// <param name="measuringPointCount">Adott mintavételi helyhez tartozó mérési pontok száma</param>
        /// <param name="id">Mintavételi hely id</param>
        public MeasuringLocation(int paletteId, int measuringPointCount, int id)
        {
            Id = id;

            //2016.06.19 Kanyó: hozzáadni annyi új mérési pontot a default paletta azonosítóval, amennyi kell
            //Itt a value tagváltozók null-ok, később kapnak értéket a felületről
            for (int i = 0; i < measuringPointCount; i++)
            {
                MeasuringPoint point = new MeasuringPoint();
                point.PaletteId = paletteId;
                MeasuringPoints.Add(point);
            }
        }

        /// <summary>
        /// Kijelölt példány koordinátáját átírja 
        /// </summary>
        /// <param name="x">Új X koordináta</param>
        /// <param name="y">Új Y koordináta</param>
        //Azért ide teszem, és nem a managerbe, mert drag'n'dropnál minden pontra újra ki kellene keresnie a listából, laggolna.
        public void MoveLocation(float x, float y)
        {
            this.CordX = x;
            this.CordY = y;
        }
    }
}
