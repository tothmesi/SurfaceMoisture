using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurfaceMoistureLib.Measuring;
using SurfaceMoistureLib.Palettes;

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
        public PaletteManager PaletteManager = new PaletteManager();
        public HeightManager HeightManager = new HeightManager();

        public void AddPalette(string name, int[] scaleValues, int max)
        {
            var palette = new Palette()
            {
                //TODO név hol legyen beállítva?
                Name = name,
                IsBuiltIn = false
            };

            palette.SetPalette(scaleValues, max);
            PaletteManager.Palettes.Add(palette);
        }

        /// <summary>
        /// Paletta törlése
        /// </summary>
        /// <param name="paletteId"></param>
        /// <returns>Érintett mérési helyek azonosítói</returns>
        public int[] RemovePalette(int paletteId)
        {
            

            //TODO megnézni, hogy valamelyik mérési ponthoz hozzátartozik-e
            //ha igen, akkor szólni kell a felhasználónak, hogy melyik érintett
            //ha nincs, akkor törölhető a paletták közül
            return null;
        }

        
    }
}
