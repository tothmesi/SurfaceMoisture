﻿namespace SurfaceMoistureLib
{
    public struct Color
    {
        public byte R;
        public byte G;
        public byte B;

        public override string ToString()
        {
            return string.Format("RGB: [{0}, {1}, {2}]",R,G,B);
        }
    }
}
