namespace template_csharp_reviews_site.Models
{
    public class SchoolSupply
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description;
        public double Price;
        public SupplyType SupplyType;
        public AgeGroup AgeGroup;
        
            
    }
    public enum AgeGroup
    { Pre_K, ElemSchool, MiddleSchool, HighSchool, College
    }
    public enum SupplyType
    {
        Writing,Binders,Calculator,Backpacks
    }


}
