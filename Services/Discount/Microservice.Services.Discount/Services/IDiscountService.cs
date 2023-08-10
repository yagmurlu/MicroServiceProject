using CasgemMicrosrvice.Shared.Dtos;
using Microservice.Services.Discount.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservice.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync();
        Task<Response<ResultDiscountDto>> GetByIdDiscountCouponsAsync(int id);
        Task<Response<NoContent>> UpdateDiscountCouponAsync(UpdateDiscountDto updateDiscountDto);
        Task<Response<NoContent>> CreateDiscountCouponAsync(CreateDiscountDto createDiscountDto);
        Task<Response<NoContent>> DeleteDiscountCouponAsync(int id);
    }
}
