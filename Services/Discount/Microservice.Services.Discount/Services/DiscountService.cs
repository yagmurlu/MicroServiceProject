using AutoMapper;
using CasgemMicrosrvice.Shared.Dtos;
using Microservice.Services.Discount.Context;
using Microservice.Services.Discount.Dtos;
using Microservice.Services.Discount.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _dapperContext;
        private readonly IMapper _mapper;
        public DiscountService(DapperContext dapperContext, IMapper mapper)
        {
            _dapperContext = dapperContext;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> CreateDiscountCouponAsync(CreateDiscountDto createDiscountDto)
        {
            var createCoupon = _mapper.Map<DiscountCoupons>(createDiscountDto);
            createCoupon.CreatedTime = DateTime.Now;
            await _dapperContext.DiscountCouponses.AddAsync(createCoupon);
            await _dapperContext.SaveChangesAsync();
            return Response<NoContent>.Success(201);
        }

        public async Task<Response<NoContent>> DeleteDiscountCouponAsync(int id)
        {
            var result=await _dapperContext.DiscountCouponses.FindAsync(id);
            if (result==null)
            {
                return Response<NoContent>.Fail("Silinecek Kupon Bulunamadı", 404);
            }
            _dapperContext.DiscountCouponses.Remove(result);
            _dapperContext.SaveChanges();
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync()
        {
            var values = await _dapperContext.DiscountCouponses.ToListAsync();
            return Response<List<ResultDiscountDto>>.Success(_mapper.Map<List<ResultDiscountDto>>(values), 200);

        }

        public async Task<Response<ResultDiscountDto>> GetByIdDiscountCouponsAsync(int id)
        {
            var result = await _dapperContext.DiscountCouponses.FindAsync(id);
            return Response<ResultDiscountDto>.Success(_mapper.Map<ResultDiscountDto>(result), 200);
        }

        public async Task<Response<NoContent>> UpdateDiscountCouponAsync(UpdateDiscountDto updateDiscountDto)
        {
            var existingResponse = await _dapperContext.DiscountCouponses.FindAsync(updateDiscountDto.DiscountCouponsID);
            if (existingResponse==null)
            {
                return Response<NoContent>.Fail("Güncellenecek Kupon Bulunamadı",404);

            }
            _mapper.Map(updateDiscountDto, existingResponse);
            _dapperContext.DiscountCouponses.Update(existingResponse);
            await _dapperContext.SaveChangesAsync();
            return Response<NoContent>.Success(204);

        }
    }
}
