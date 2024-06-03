using System.Text.Json.Serialization;

namespace EcomerceApp.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore] // Ngăn việc serialize/deserialize Product trong ProductImage
        public Product Product { get; set; }
        
    }
}
