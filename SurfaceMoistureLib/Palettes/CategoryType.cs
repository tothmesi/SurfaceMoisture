using System.ComponentModel;

namespace SurfaceMoistureLib
{
    public enum CategoryType
    {
        [Description("Nincs érték")]
        NoValue = 0,
        
        [Description("Száraz")]
        Dry = 1,

        [Description("Enyhén nedves")]
        SoftWet = 2,

        [Description("Nedves")]
        Wet = 3,

        [Description("Vizes")]
        ExremelyWet = 4
    }
}
