using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceMoistureLib.Measuring
{
    public class HeightManager
    {
        public readonly List<int> Heights = new List<int>();
        
        public void RemoveHeight()
        {
            Heights.RemoveAt(Heights.Count - 1);
        }

        public void ModifyHeight(int index, int value)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
