using System.Text.Json.Serialization;

namespace EcomerceApp.Models
{
    public class OrderItem
    {

        public int Id { get; set; }
        public int OrderId { get; set; } // Lưu trữ OrderId
        [JsonIgnore]
        public Order Order { get; set; } // Tham chiếu đến Order tương ứng
        public int ProductId { get; set; }
        public string ProductName { get; set; } // Tên sản phẩm
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Giá của sản phẩm hoặc biến thể
        public int? VariantId { get; set; } // ID của biến thể (nếu có)
    }
}
