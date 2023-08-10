using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CasgemMicroservice.Services.Basket.Dtos
{
    public class BasketDto
    {
        public string UserID { get; set; }
        public string DiscountCode { get; set; }
        public int? DiscountRate { get; set; }
        public List<BasketItemDto> basketItems { get;}
        public decimal TotalPrice
        {
            get => basketItems.Sum(x => x.Price * x.Quantity);
        }
    }
}
