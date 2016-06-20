namespace SurfaceMoistureLib
{
    public class Interval
    {
        /// <summary>
        /// Az intervallum kezdete a műszer saját skálája alapján
        /// </summary>
        public int From;

        /// <summary>
        /// Az intervallum vége a műszer saját skálája alapján
        /// </summary>
        public int To;

        public CategoryType Type;

        public override string ToString()
        {
            return string.Format("Intervallum: [{0} - {1}], {2}", From, To, Type);
        }

        /// <summary>
        /// Az érték benne van-e az intervallumban
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsInInterval(int value)
        {
            return (From <= value && value < To);
        }

    }
}
