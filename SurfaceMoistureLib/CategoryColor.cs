using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceMoistureLib
{
    public class CategoryColor
    {
        //Van egy külön enum a katagóriák neveivel (CategoryColorType), ehhez rendelem hozzá a színeket egy dictionaryben
        Dictionary<CategoryType, Color> colors = new Dictionary<CategoryType, Color>();


        public Color? GetColor(CategoryType type)
        {
            if (colors.ContainsKey(type))
                return colors[type];
            
            return null;
        }

        //Ezt kell meghívnom a "Nincs érték"-re is, és majd a színezésnél dönti el, ha van érték, a négy másikból választ
        //ha nincs érték, akkor értelemszerűen azt
        public void SetColor(CategoryType type, Color color) 
        {
            if (colors.ContainsKey(type))
            {
                //módosítom a színét
                colors[type] = color;
            }
            else
            {
                //felveszem
                colors.Add(type, color);
            }
        }
    }
}
