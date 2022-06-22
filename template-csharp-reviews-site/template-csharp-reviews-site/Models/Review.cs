namespace template_csharp_reviews_site.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Opinions { get; set; }
        public DateTime Postdate { get; set; }
        public bool Positive { get; set; }
        public int SchoolSupplyId { get; set; }
        public virtual SchoolSupply SchoolSupply    { get; set; }
        public string Author { get; set; }

        
        //public Review(int id, int rating, string opinions, DateTime dateTime, bool positive, string Productname, string author)
        //{
        //    Id = id;
        //    Rating = rating;
        //    Opinions = opinions;
        //    DateTime = dateTime;
        //    Positive = positive;
        //    ProductName = Productname;
        //    Author = author;
        //}
    }
   
}
