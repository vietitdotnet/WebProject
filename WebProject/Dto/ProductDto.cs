namespace WebProject.Dto
{
    public class ProductDto
    {
        public string ID { get; set; }

        public string SKU { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal CostPrice { get; set; }

        public string ImageURL { get; set; }

        public bool IsActive { get; set; }
    }
}
