namespace template_csharp_reviews_site.Models
{
    public class Review
    {
        public int Id;
        public int Rating;
        public string Opinions;
        public DateTime DateTime;
        public bool Positive;
        public string Name;
        public Review(int id, int rating, string opinions, DateTime dateTime, bool positive, string name)
        {
            Id = id;
            Rating = rating;
            Opinions = opinions;
            DateTime = dateTime;
            Positive = positive;
            Name = name;
        }
    }
   
}
