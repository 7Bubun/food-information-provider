namespace DataAccessDapper.Model
{
    public class ProductDTO
    {
        public string Product_Tag { get; set; }
        public string Product_Name { get; set; }
        public string Energy_Value_Range { get; set; }
        public string Pros { get; set; }

#nullable enable
        public string? Cons { get; set; }
        public string? Additional { get; set; }
    }
}
