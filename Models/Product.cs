using System.Text.Json.Serialization;

namespace EcomerceApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Information { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore] // Ngăn việc serialize/deserialize Category trong Product
        public Category Category { get; set; }
        public List<ProductImage>? Images { get; set; }
        public List<ProductVariant>? Variants { get; set; }
    }
}
