using static ApplicationCore.Constant.Constants;

namespace ApplicationCore.Models
{
   public class MovieCastModel
    {
        public int CastId { get; set; }
        public string Name { get; set; }
        public string TmdbUrl { get; set; }
        public string ProfilePath { get; set; }
        public int MovieId { get; set; }
        public string Character { get; set; }
        public ScopesVersions ScopesVersion { get; set; }
    }
}
