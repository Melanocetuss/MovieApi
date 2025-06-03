namespace MovieApi.Domain.Entities
{
    public class RelatedMovie
    {
        public int RelatedMovieID { get; set; }
        public int MovieID { get; set; }
        public int UserID { get; set; }
        public bool IsWatch { get; set; }
    }
}