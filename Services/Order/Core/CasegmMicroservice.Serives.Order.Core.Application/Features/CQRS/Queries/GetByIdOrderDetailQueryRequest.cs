using CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderDetailDtos;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderingDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Queries
{
	public class GetByIdOrderDetailQueryRequest : IRequest<ResultOrderDetailDto>
	{
		public int Id { get; set; }
		public GetByIdOrderDetailQueryRequest(int id)
		{
			Id = id;
		}
	}
}
