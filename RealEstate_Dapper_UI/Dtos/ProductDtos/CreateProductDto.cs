namespace RealEstate_Dapper_UI.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string Productcity { get; set; }
        public string Productdistrict { get; set; }
        public string categoryid { get; set; }
        public string Productcoverimage { get; set; }
        public string type { get; set; }
        public string ProductAddress { get; set; }
    }
}
