using EcomerceApp.Models;
using EcomerceApp.Models.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EcomerceApp.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {

            Random random = new Random();

            // Seed ProductCategories
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Scented Candle",
                        Products = new List<Product>
                        {
                            new Product
                            {
                                Name = "Sáp thơm hoa trà nước hoa",
                                Description = "Sáp thơm hoa trà nước hoa là một hòa quyện tinh tế giữa hương thơm dịu dàng của hoa trà và sự tinh tế của sáp thơm. Mỗi viên sáp đều chứa đựng một cảm xúc, một hình ảnh hoa trà nở rộ trong ánh nắng chiều, lan tỏa một hương thơm thanh khiết, dịu dàng và quyến rũ.\r\nKhi bạn cháy sáp, từng giọt hương thơm nhẹ nhàng lan tỏa, lấp đầy không gian với một bản hòa âm dịu dàng, mang lại cảm giác thư thái, êm dịu và lạc quan. Hương thơm của hoa trà nước hoa không chỉ là sự kết hợp hoàn hảo giữa sự tươi mới của hoa và đất, mà còn là một lời tri ân đến vẻ đẹp tự nhiên và sự tinh tế của cuộc sống.\r\n",
                                Images = new List<ProductImage>
                                {
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/9kK4JLF"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/mh8t0K2"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/BOVg2DY"
                                    }
                                },
                                Information = "Trọng lượng: 50G.\r\nNguyên liệu: Làm từ tinh dầu thiên nhiên nguyên chất và thạch cao.\r\nThời gian lưu hương: 20-30 ngày.\r\nKích thước hộp: 16.5x10.5cm.\r\nHạn sử dụng: 3 năm kể từ ngày sản xuất.\r\nTốc độ tỏa mùi nhanh, bung tỏa hương thơm chỉ trong giây lát\r\n",
                                Variants = new List<ProductVariant>
                                {
                                    new ProductVariant
                                    {
                                        Name = "Amber Mun",
                                        Price = 30000,
                                        ImgUrl = " https://imgur.com/GRWuC6K",
                                        Quantity = GenerateRandomQuantity(random),
                                        
                                    },
                                    new ProductVariant
                                    {
                                        Name = "Freesia",
                                        Price = 30000,
                                        ImgUrl = "https://imgur.com/Z3UAEDs",
                                        Quantity = GenerateRandomQuantity(random)

                                    },
                                    new ProductVariant
                                    {
                                        Name = "Gardenia",
                                        Price = 30000,
                                        ImgUrl = "https://imgur.com/fEIHxYO",
                                        Quantity = GenerateRandomQuantity(random)
                                    },
                                    new ProductVariant
                                    {
                                        Name = "Bluebell",
                                        Price = 30000,
                                        ImgUrl = "https://imgur.com/5S7gG0U",
                                        Quantity = GenerateRandomQuantity(random)
                                    },
                                    new ProductVariant
                                    {
                                        Name = "Trà trắng",
                                        Price = 30000,
                                        ImgUrl = "https://imgur.com/iiM84ej",
                                        Quantity = GenerateRandomQuantity(random)
                                    },
                                }
                            },

                            new Product
                            {
                                Name = "Nến thơm",
                                Description = "Nến thơm không chỉ là một nguồn ánh sáng ấm áp mà còn là một phương tiện để tạo không gian thơm dịu và thư giãn. Mỗi chiếc nến mang theo một câu chuyện riêng, từng giọt sáp tan chảy là một khoảnh khắc của hương thơm êm dịu tràn ngập không gian.\r\nHương thơm từ nến thơm có thể đa dạng, từ những hương trái cây tươi mới, đến những hương hoa nồng nàn hay những hương gỗ ấm áp. Khi nến được đốt, hương thơm dịu nhẹ lan tỏa, tạo ra một bản hòa âm đầy quyến rũ cho không gian xung quanh.\r\nNến thơm không chỉ làm cho không gian trở nên ấm áp và lãng mạn hơn, mà còn có thể giúp giảm căng thẳng và lo lắng, tạo ra một môi trường thư giãn và yên bình. Với nến thơm, mỗi không gian trở nên đặc biệt hơn, mỗi khoảnh khắc trở nên đáng nhớ hơn, tạo ra những trải nghiệm tuyệt vời cho mọi người.\r\n",
                                Images = new List<ProductImage>
                                {
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/fMRJpMU"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/yUDeF7Q"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/uVj3Z9q"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/Cks5JSj"
                                    }
                                },
                                Information = "Trọng lượng: 30gr/c\r\nNguyên liệu: Sáp đậu nành cao cấp.\r\nKích thước hộp:\r\n+ Hộp 4chiếc: 7x7x4\r\n+ Hộp 1c: 6x6x3\r\nHạn sử dụng: 3 năm kể từ ngày sản xuất\r\nTốc độ tỏa mùi nhanh, bung tỏa hương thơm chỉ trong giây lát\r\nCÔNG DỤNG:\r\n- Nến toả hương thơm ngay cả khi chưa đốt, khử mùi hôi, ẩm mốc trong không gian.\r\n- Nến giải tỏa stress, căng thẳng, mệt mỏi, tăng khả năng tập trung.\r\n- Nến tăng cường kháng khuẩn trong không khí.\r\n",
                                Variants = new List<ProductVariant>
                                {
                                    new ProductVariant
                                    {
                                        Name = "Combo 1",
                                        Price = 50000,
                                        ImgUrl = "https://imgur.com/7RfPkeO",
                                        Quantity = GenerateRandomQuantity(random)
                                    },
                                    new ProductVariant
                                    {
                                        Name = "Combo 1",
                                        Price = 200000,
                                        ImgUrl = "https://imgur.com/fMRJpMU",
                                        Quantity = GenerateRandomQuantity(random)
                                    }
                                }
                            }
                        }
                    },
                    new Category
                    {
                         Name = "Scented Wax",
                         Products = new List<Product>
                        {
                            new Product
                            {
                                Name = "Viên Đá Hoa Anh Đào Thơm",
                                Description = "Viên Đá Hoa Anh Đào Thơm là một tác phẩm tự nhiên đẹp mắt, kết hợp giữa vẻ đẹp tinh tế của đá tự nhiên và hương thơm dịu dàng của hoa anh đào. Mỗi viên đá đều là một tác phẩm độc đáo, với những vân đá tự nhiên tinh tế, tạo nên một bức tranh tự nhiên tinh tế và trang nhã.\r\nKhi bạn đặt viên đá này vào không gian của mình, không chỉ tạo điểm nhấn trang trí độc đáo mà còn mang lại một hơi thở mới mẻ và thư thái. Hương thơm nhẹ nhàng của hoa anh đào tự nhiên được tỏa ra từ viên đá, lan tỏa khắp không gian với sự dịu dàng và quyến rũ.\r\nViên Đá Hoa Anh Đào Thơm không chỉ là vật trang trí đẹp mắt mà còn là một cách tuyệt vời để thư giãn và thư thái sau những ngày làm việc căng thẳng. Nó là sự kết hợp hoàn hảo giữa sự thanh lọc không gian và tinh thần, mang lại cảm giác thư thái và yên bình cho mỗi không gian sống.\r\n",
                                Images = new List<ProductImage>
                                {
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/9kK4JLF"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/mh8t0K2"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/BOVg2DY"
                                    }
                                },
                                Information = "Trọng lượng: 50G.\r\nNguyên liệu: Làm từ tinh dầu thiên nhiên nguyên chất và thạch cao.\r\nThời gian lưu hương: 20-30 ngày.\r\nKích thước hộp: 16.5x10.5cm.\r\nHạn sử dụng: 3 năm kể từ ngày sản xuất.\r\nTốc độ tỏa mùi nhanh, bung tỏa hương thơm chỉ trong giây lát\r\n",
                                Variants = new List<ProductVariant>
                                {
                                    new ProductVariant
                                    {
                                        Name = "Blue Wind Chime",
                                        Price = 30000,
                                        ImgUrl = "https://imgur.com/Fg7CRBc",
                                        Quantity = GenerateRandomQuantity(random),

                                    },
                                    new ProductVariant
                                    {
                                        Name = "White Peach Olong",
                                        Price = 30000,
                                        ImgUrl = "https://imgur.com/JNc7PSk",
                                        Quantity = GenerateRandomQuantity(random)

                                    },
                                    new ProductVariant
                                    {
                                        Name = "British pear & Freesia",
                                        Price = 30000,
                                        ImgUrl = "https://imgur.com/J5j9tOo",
                                        Quantity = GenerateRandomQuantity(random)
                                    },
                                    new ProductVariant
                                    {
                                        Name = "Westin White Tea",
                                        Price = 30000,
                                        ImgUrl = "https://imgur.com/YTSre7C",
                                        Quantity = GenerateRandomQuantity(random)
                                    },
                                    
                                }
                            }
                        }
                    },
                    new Category
                    {
                         Name = "Scrunchies",
                         Products = new List<Product>
                         {
                            new Product
                            {
                                Name = "Scrunchies",
                                Description = "- Scrunchies được sử dụng để buộc tóc, làm phụ kiện cho tóc\r\n- Giúp bạn đẹp hơn, nổi bật hơn, phù hợp cho bạn trong nhiều hoạt động\r\n- Giá thành phù hợp để bạn dễ dàng thay đổi phong cách mỗi ngày\r\n- Được làm bằng thun đàn hồi kết hợp vải chất lượng cao\r\n- Nhỏ gọn, xinh xắn, rất dễ dàng cho việc sử dụng, bảo quan và mang theo mỗi khi di chuyển\r\n",
                                Images = new List<ProductImage>
                                {
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/BQbKFSD"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/L7fq42Z"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/rV7JphN"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/W7s8J27"
                                    }
                                },
                                Information = "- Chất liệu:  Vải\r\n- Màu sắc:  Nhiều màu\r\n- Style: Hàn Quốc\r\n- Trọng lượng: 10g\r\n- Kích thước: bán kính 4cm\r\n"

                            }
                        }
                    },
                    new Category
                    {
                         Name = "Hairclip",
                         Products = new List<Product>
                         {
                            new Product
                            {
                                Name = "Hairclip",
                                Description = "- Được sử dụng để kẹp tóc, làm phụ kiện và tạo kiểu cho tóc\r\n- Giúp bạn đẹp hơn, nổi bật hơn, phù hợp cho bạn trong nhiều hoạt động\r\n- Giá thành phù hợp để bạn dễ dàng thay đổi phong cách mỗi ngày\r\n- Được làm bằng hợp kim kết hợp các chi tiết đẹp\r\n- Nhỏ gọn, xinh xắn, rất dễ dàng cho việc sử dụng, bảo quan và mang theo mỗi khi di chuyển\r\n",
                                Images = new List<ProductImage>
                                {
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/L9j1kWJ"
                                    }
                                   
                                },
                                Information = "- Chất liệu: hợp kim\r\n- Màu sắc:  Như ảnh minh họa\r\n- Style: Hàn Quốc\r\n- Trọng lượng: 20g\r\n- Kích thước: tương ứng ở từng sản phẩm\r\n",
                                Variants = new List<ProductVariant>
                                {
                                    new ProductVariant
                                    {
                                        Name = "11cm",
                                        Price = 40000,
                                        ImgUrl = "https://imgur.com/ZTisVNI",
                                        Quantity = GenerateRandomQuantity(random),

                                    },
                                    new ProductVariant
                                    {
                                        Name = "8cm",
                                        Price = 31000,
                                        ImgUrl = "https://imgur.com/L9j1kWJ",
                                        Quantity = GenerateRandomQuantity(random)

                                    },
                                    new ProductVariant
                                    {
                                        Name = "7.5cm",
                                        Price = 28000,
                                        ImgUrl = "https://imgur.com/gW6dPAq",
                                        Quantity = GenerateRandomQuantity(random)
                                    },
                                    new ProductVariant
                                    {
                                        Name = "8.3cm",
                                        Price = 36000,
                                        ImgUrl = "https://imgur.com/UByhNXz",
                                        Quantity = GenerateRandomQuantity(random)
                                    },

                                }
                            }
                         }
                    },
                    new Category
                    {
                          Name = "Bandana",
                          Products = new List<Product>
                          {
                            new Product
                            {
                                Name = "Bandana",
                                Description = "- Bandana được sử dụng để buộc tóc, làm phụ kiện thời trang\r\n- Giúp bạn đẹp hơn, nổi bật hơn, phù hợp cho bạn trong nhiều hoạt động\r\n- Giá thành phù hợp để bạn dễ dàng thay đổi phong cách mỗi ngày\r\n- Nhỏ gọn, xinh xắn, rất dễ dàng cho việc sử dụng\r\nHướng dẫn giặt và bảo quản :\r\n-Giặt tay nhẹ nhàng \r\n-Phơi tránh ánh nắng trực tiếp. \r\n-Ủi ở nhiệt độ thấp.\r\n",
                                Images = new List<ProductImage>
                                {
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/micwz7"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/fhLksxI"
                                    },
                                    new ProductImage
                                    {
                                        Url = "https://imgur.com/cpdIfyT"
                                    },

                                },
                                Information = "- Chất liệu:  Ren\r\n- Màu sắc:  màu kem, hồng, xanh\r\n- Style: Hán Quốc\r\n- Trọng lượng: 15g\r\n- Kích thước: khoảng 90*35cm\r\n",
                                Variants = new List<ProductVariant>
                                {
                                    new ProductVariant
                                    {
                                        Name = "Trắng",
                                        Price = 35000,
                                        ImgUrl = "https://imgur.com/BdYFOLP",
                                        Quantity = GenerateRandomQuantity(random),

                                    },
                                    new ProductVariant
                                    {
                                        Name = "Xanh",
                                        Price = 35000,
                                        ImgUrl = "https://imgur.com/2vDAX9R",
                                        Quantity = GenerateRandomQuantity(random)

                                    },
                                    new ProductVariant
                                    {
                                        Name = "Hồng",
                                        Price = 35000,
                                        ImgUrl = "https://imgur.com/275NVVJ",
                                        Quantity = GenerateRandomQuantity(random)
                                    }
                                }
                            }
                          }
                    }

                );

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Category---------" + ex.Message);
                }
            }


            // Seed Roles
            if (!context.Roles.Any())
            {
                string[] roles = { "Admin", "User", "Blogger" };
                foreach (var role in roles)
                {
                    context.Roles.Add(new IdentityRole
                    {
                        Name = role,
                        NormalizedName = role.ToUpper(),
                        ConcurrencyStamp = Guid.NewGuid().ToString()
                    });
                }

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Role----------" + ex.Message);
                }
            }

            // Seed Users
            if (!context.Users.Any())
            {
                const int numberOfUsers = 100; // Number of users to create
                for (int i = 0; i < numberOfUsers; i++)
                {
                    string userName = "User" + i;
                    string email = "user" + i + "@example.com";
                    string password = "123456";

                    context.Users.Add(new ApplicationUser
                    {
                        UserName = userName,
                        Email = email,
                        EmailConfirmed = true,
                        NormalizedEmail = email.ToUpper(),
                        NormalizedUserName = userName.ToUpper(),
                        SecurityStamp = Guid.NewGuid().ToString("D"),
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, password),
                        imgUrl = "https://i1.sndcdn.com/artworks-000065334969-gmnp3t-t500x500.jpg"
                    });
                }

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("User-----------" + ex.Message);
                }
            }

            // Seed UserRoles
            if (!context.UserRoles.Any())
            {
                var userList = context.Users.ToList();
                var roleList = context.Roles.ToList();
                foreach (var user in userList)
                {
                    int numberOfRoles = random.Next(1, 4);
                    var selectedRoles = roleList.OrderBy(r => random.Next()).Take(numberOfRoles).ToList();
                    foreach (var role in selectedRoles)
                    {
                        context.UserRoles.Add(new IdentityUserRole<string>
                        {
                            UserId = user.Id,
                            RoleId = role.Id
                        });
                    }
                }

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("UserRole-----------" + ex.Message);
                }
            }

            // Seed Orders and OrderItems
            if (!context.Orders.Any())
            {
                const int numberOfOrders = 50; // Số lượng đơn hàng muốn tạo

                var variantList = context.ProductVariants.Include(v => v.Product).ToList();
                var userList = context.Users.ToList();

                for (int i = 0; i < numberOfOrders; i++)
                {
                    // Tạo đơn hàng
                    var order = new Order
                    {
                        ApplicationUserId = userList[random.Next(userList.Count)].Id,
                        CreatedAt = RandomDateTime(2020, 2024), // Đặt ngẫu nhiên thời gian đơn hàng từ năm 2020 đến năm 2024
                        Status = OrderStatus.Paid, // Giả sử tất cả các đơn hàng đều đã hoàn thành
                        PaymentInfo = new PaymentInfo
                        {
                            PaymentMethod = (random.Next(0, 3) == 1 ? PaymentMethod.BankTransfer : PaymentMethod.CashOnDelivery), // Phương thức thanh toán khi nhận hàng
                            CardHolderName = "Nguyễn Văn A", // Tên chủ thẻ
                            CardNumber = "1234567890" // Số thẻ ngân hàng
                        },
                        Address = GenerateRandomString(random, 50), // Địa chỉ ngẫu nhiên
                        Notes = GenerateRandomString(random, 100), // Ghi chú ngẫu nhiên
                        PhoneNumber = "0123456789" // Số điện thoại ngẫu nhiên
                    };

                    // Thêm đơn hàng vào danh sách
                    context.Orders.Add(order);

                    try
                    {
                        context.SaveChanges(); // Lưu trữ tất cả các đơn hàng sau khi chúng được tạo xong

                        // Sau khi đã lưu đơn hàng, bạn có thể lấy đơn hàng đã tạo
                        var createdOrder = context.Orders.FirstOrDefault(o => o.Id == order.Id);

                        if (createdOrder != null)
                        {
                            // Tạo số lượng mục đặt hàng ngẫu nhiên cho mỗi đơn hàng
                            int numberOfItems = random.Next(1, 5); // Số lượng mục đặt hàng ngẫu nhiên từ 1 đến 5
                            for (int j = 0; j < numberOfItems; j++)
                            {
                                var variant = variantList[random.Next(variantList.Count)];

                                // Kiểm tra xem productId đã có trong đơn hàng này chưa
                                if (!context.OrderItems.Any(oi => oi.OrderId == createdOrder.Id && oi.ProductId == variant.Product.Id))
                                {
                                    var orderItem = new OrderItem
                                    {
                                        ProductId = variant.Product.Id, // Lấy ID sản phẩm từ biến thể
                                        Quantity = random.Next(1, 5), // Số lượng ngẫu nhiên từ 1 đến 5
                                        Price = variant.Price, // Giá của sản phẩm từ biến thể
                                        VariantId = variant.Id, // ID biến thể
                                        ProductName = variant.Product.Name, // Tên sản phẩm từ biến thể
                                        OrderId = createdOrder.Id // Gán OrderId cho mỗi OrderItem sử dụng Id đã được tạo ra trước đó
                                    };

                                    // Thêm OrderItem vào danh sách
                                    context.OrderItems.Add(orderItem);
                                }
                            }
                        }

                        context.SaveChanges(); // Lưu trữ tất cả các mục đặt hàng sau khi chúng được tạo xong
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Orders and OrderItems-----------" + ex.Message);
                    }
                }
            }




        }

        private static int GenerateRandomQuantity(Random random)
        {
            return random.Next(10, 100);
        }

        private static string GenerateRandomString(Random random, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static DateTime RandomDateTime(int startYear, int endYear)
        {
            Random random = new Random();
            DateTime startDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear + 1, 1, 1).AddDays(-1);
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan randomSpan = new TimeSpan(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);
            return startDate + randomSpan;
        }
    }

      
}
