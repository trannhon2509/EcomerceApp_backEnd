using Microsoft.AspNetCore.Identity;

namespace EcomerceApp.Models;

public class ApplicationUser : IdentityUser
{
    public string imgUrl { get; set; } = "https://th.bing.com/th?id=OIP.R4zTXI4N6_5iPWfLFzM8UgHaHa&w=250&h=250&c=8&rs=1&qlt=90&o=6&pid=3.1&rm=2";
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public bool IsActive { get; set; } = true;


}
