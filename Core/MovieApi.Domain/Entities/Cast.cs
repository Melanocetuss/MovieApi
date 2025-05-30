namespace MovieApi.Domain.Entities
{
    public class Cast
    {
        public int CastID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CoverImageUrl { get; set; }
        public string? OverView { get; set; }
        public string? Biography { get; set; }
    }
}