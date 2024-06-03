using EcomerceApp.Models.Enum;

namespace EcomerceApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Address { get; set; } // Địa chỉ
        public string PhoneNumber { get; set; } // Số điện thoại liên lạc
        public List<OrderItem> Items { get; set; }
        public decimal Total
        {
            get
            {
                // Tính tổng tiền từ danh sách các mục đặt hàng
                return Items.Sum(item => item.Quantity * item.Price);
            }
        } // Tổng tiền
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Thời gian tạo đơn hàng
        public string? Notes { get; set; } // Ghi chú của người dùng
        public OrderStatus Status { get; set; } = OrderStatus.Pending;// Trạng thái đơn hàng

        // Thông tin thanh toán
        public PaymentInfo PaymentInfo { get; set; }

        // Thêm các thuộc tính sau
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
