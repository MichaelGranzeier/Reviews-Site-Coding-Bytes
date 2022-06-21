namespace template_csharp_reviews_site.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating;
        public string Opinions;
        public DateTime DateTime;
        public bool Positive;
        public string ProductName;
        public string Author;
        public Review(int id, int rating, string opinions, DateTime dateTime, bool positive, string Productname, string author)
        {
            Id = id;
            Rating = rating;
            Opinions = opinions;
            DateTime = dateTime;
            Positive = positive;
            ProductName = Productname;
            Author = author;
        }
    }
   
}
