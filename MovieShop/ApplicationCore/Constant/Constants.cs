
namespace ApplicationCore.Constant
{
    public class Constants
    {
        public enum ScopesVersions : short
        {
            V1 = 1,
            V2 = 2,
        }

        public struct RatingLevel
        {
            public const string Below = "BelowAverage";
            public const string High = "HigherThanAverage";
            public const string Average = "Average";
        }
    }
}
