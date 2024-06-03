using System.Text.Json.Serialization;

namespace EcomerceApp.Models
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public string? ImgUrl { get; set; } = "https://via.placeholder.com/150";
        public int Quantity { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore] // Ngăn việc serialize/deserialize Product trong ProductVariant
        public Product Product { get; set; }
    }
}
