using CasgemMicroservice.Services.Discount.Dtos;
using CasgemMicroservice.Services.Discount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCouponsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountCouponsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDiscountCoupons()
        {
            var values = await _discountService.GetAllDiscountCouponsAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllDiscountCoupons(int id)
        {
            var values = await _discountService.GetByIdDiscountCouponsAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountDto createDiscountDto)
        {
            await _discountService.CreateDiscountCouponAsync(createDiscountDto);
            return Ok("Kupon Başarıyla Oluşturuldu");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountDto updateDiscountDto)
        {
            await _discountService.UpdateDiscountCouponAsync(updateDiscountDto);
            return Ok("Kupon Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountService.DeleteDiscountCouponAsync(id);
            return Ok("Kupon Başarıyla Silindi");
        }
    }
}
