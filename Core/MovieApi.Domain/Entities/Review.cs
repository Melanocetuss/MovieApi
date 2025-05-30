namespace MovieApi.Domain.Entities
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string ReviewComment { get; set; }
        public int UserRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool Status { get; set; }
    }
}