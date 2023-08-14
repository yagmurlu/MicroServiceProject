using AutoMapper;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderingDtos;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Mappings
{
	public class OrderProfile:Profile
	{
		public OrderProfile()
		{
			CreateMap<ResultOrderDto, Ordering>().ReverseMap();
			CreateMap<CreateOrderDto, Ordering>().ReverseMap();
			CreateMap<UpdateOrderDto, Ordering>().ReverseMap();

		}
	}
}
