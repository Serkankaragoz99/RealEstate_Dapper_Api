namespace RealEstate_Dapper_UI.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public int productID { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCity { get; set; }
        public string ProductDistrict { get; set; }
        public string categoryName { get; set; }
        public string ProductCoverimage { get; set; }
        public string Type { get; set; }
        public string ProductAddress { get; set; }
    }
}
