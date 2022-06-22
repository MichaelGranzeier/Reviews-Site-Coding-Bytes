namespace template_csharp_reviews_site.Models
{
    public class SchoolSupply
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public SupplyType SupplyType { get; set; }
        public AgeGroup AgeGroup { get; set; }
        public virtual List<Review> Reviews { get; set; }
        
            
    }
    public enum AgeGroup
    { Pre_K, ElemSchool, MiddleSchool, HighSchool, College
    }
    public enum SupplyType
    {
        Writing,Binders,Calculator,Backpacks
    }


}
