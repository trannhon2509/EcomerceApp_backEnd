using EcomerceApp.Models.Enum;

namespace EcomerceApp.Models
{
    public class PaymentInfo
    {
        public int Id { get; set; } // Id của thông tin thanh toán
        public string CardNumber { get; set; } // Số thẻ ngân hàng
        public string CardHolderName { get; set; } // Tên chủ thẻ
        public PaymentMethod PaymentMethod { get; set; } // Phương thức thanh toán (Ví dụ: thẻ tín dụng, chuyển khoản)
    }
}
