using System.Linq;
using SurfaceMoistureLib.Exceptions;

namespace SurfaceMoistureLib
{
    public class Palette
    {
        public readonly int Id;
        public string Name;
        public readonly Interval[] Intervals = new Interval[4];

        /// <summary>
        /// Beépített paletta
        /// </summary>
        public bool IsBuiltIn;

        public Palette(int id, int[] scaleValues, int max, string name)
        {
            Id = id;
            SetPalette(scaleValues, max);
            Name = name;
        }

        /// <summary>
        /// Beállítom a palettához tartozó szárazsági kategóriák tartományait
        /// </summary>
        /// <param name="scaleValues">Az egyes anyagokra vonatkozó mérési skála felső értékei</param>
        /// <param name="max">A műszer mérési tartományának felső korlátja</param>
        public void SetPalette(int[] scaleValues, int max)
        {
            //TODO 2016.06.19 Kanyó: name?

            //Azért SetPalette és nem konstruktorban történik, mert a példány módosításánál is 
            //ez hívódik meg - a konstruktor pedig csak egyszer hívható

            //A max paraméter logolás és ellenőrzés miatt van benne 
            //(műszer maximuma az utolsó kategória felső határa)
            int[] ordered = scaleValues.OrderBy(x => x).ToArray();

            //alsó határ ellenőrzése
            if (ordered[0] < 0)
                throw new ScaleValueOutOfRangeException(ordered[0], max);

            //felső határ ellenőrzése
            if (ordered[ordered.Length - 1] != max)
                throw new ScaleValueMismatchedToMaxException(ordered[ordered.Length - 1], max);
           
            
            //TODO 2016.06.19 Kanyó: kezelni, ha az utolsó felső határ értéke kisebb a maxnál
            //ilyenkor marad egy intervallum a mérési tartomány felső végén, 
            //hogy ha ott mér valamit, akkor az nem esik egyik tartományba sem!!


            //az egyes értékek ellenőrzése
            for (int i = 0; i < scaleValues.Length; i++)
            {
                if (scaleValues[i] != ordered[i] || (i > 0 && scaleValues[i] <= scaleValues[i - 1]))
                {
                    //ha nem egyezik meg az eleme a rendezett tömb elemével -> nem növekvő sorrendben adták meg
                    //ha nem nagyobb a következő elem az előzőnél -> nem monoton növekvő
                    throw new ScaleValuesUnorderedException(scaleValues);
                }
            }

            //a fenti ciklus ezzel ekvivalens: 
            //az eredeti lista megegyezik-e a rendezettel és 
            //megegyezik-e a lista elemszáma, ha csak a különböző elemeket veszem
            //if (!scaleValues.SequenceEqual(ordered) || scaleValues.Distinct().Count() != scaleValues.Length)
            //    throw new ScaleValuesUnorderedException(scaleValues);


            //beállítjuk a megadott értékhatárok alapján az egyes intervallumok alsó és felső határait és a kategóriját
            for (int i = 0; i < scaleValues.Length; i++)
            {
                Intervals[i] = new Interval();
                if (i == 0)
                    Intervals[i].From = 0;
                else
                    Intervals[i].From = Intervals[i - 1].To + 1;
                
                Intervals[i].To = scaleValues[i];
                Intervals[i].Type = (CategoryType) (i + 1);
            }

        }
    }
}