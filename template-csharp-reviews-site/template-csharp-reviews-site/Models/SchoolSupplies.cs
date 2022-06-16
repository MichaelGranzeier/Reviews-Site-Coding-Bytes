namespace template_csharp_reviews_site.Models
{
    public class SchoolSupplies
    {
        public int Id;
        public string Name;
        public string Description;
        public double Price;
        public SupplyType SupplyType;
        public AgeGroup AgeGroup;
            
    }
    public enum AgeGroup
    { Pre_K, ElemtrySchool, IdermiditeSchool, MiddleSchool, HighSchool, College
    }
    public enum SupplyType
    {
        Writing,Books,Binders,Calculator,Notebooks,Paper,Backpacks
    }


}
