using CasgemMicroservice.Services.Basket.Dtos;
using CasgemMicrosrvice.Shared.Dtos;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userID);
        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> DeleteBasket(string userID);
    }
}
