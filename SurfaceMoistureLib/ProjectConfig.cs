using System;
using System.Collections.Generic;
using System.Linq;
using SurfaceMoistureLib.Measuring;

namespace SurfaceMoistureLib
{


    /// <summary>
    /// Egy projecthez tartozó, átfogó beállítások, sorosítások
    /// Anyagokhoz tartozó paletták, mintavételi helyek listája, mérési magasságok száma
    /// </summary>
    public class ProjectConfig
    {
        //TODO kell majd egy függvény, ami inicializálja a project indulási értékeit
        //példányosítani kell egy MeasuringLocationManagert az inicializáló függvényben
        //3 beállított mérési magasságot (20, 90, 160)
        //egy palettát vakolatra

        public MeasuringLocationManager MeasuringLocationManager = new MeasuringLocationManager();
        public HeightManager HeightManager = new HeightManager();
        public static int PaletteIdCounter = 1;

        //readonly, mert a paletta lista referenciáját nem változtatom, csak a benne lévő elemeket
        public readonly List<Palette> Palettes = new List<Palette>();


        public void AddPalette(string name, int[] scaleValues, int max)
        {
            var palette = new Palette(PaletteIdCounter++, scaleValues, max, name);
            Palettes.Add(palette);
        }

        /// <summary>
        /// Paletta törlése
        /// </summary>
        /// <param name="paletteId"></param>
        /// <returns>Érintett mérési helyek azonosítói</returns>
        public int[] RemovePalette(int paletteId)
        {
            //Megnézni, hogy valamelyik mérési ponthoz hozzátartozik-e
            int[] results = MeasuringLocationManager
                .Locations
                .Where(x => x.MeasuringPoints.Where(y => y.PaletteId == paletteId).Any())
                .Select(z => z.Id)
                .ToArray();

            //ha igen, akkor szólni kell a felhasználónak, hogy melyik érintett
            if (results.Any())
                return results;

            //ha nincs, akkor törölhető a paletták közül
            Palette pal = Palettes.SingleOrDefault(x => x.Id == paletteId);

            if (pal != null)
                Palettes.Remove(pal);

            return null;
        }

        public void InitComponents()
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
