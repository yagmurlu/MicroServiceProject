using CasegmMicroservice.Serives.Order.Core.Application.Dtos.AddressDtos;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderingDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Queries
{
	public class GetByIdAddressQueryRequest : IRequest<ResultAddressDto>
	{
		public int Id { get; set; }
		public GetByIdAddressQueryRequest(int id)
		{
			Id = id;
		}
	}
}
