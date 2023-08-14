using CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderingDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Queries
{
	public class GetByIdOrderingQueryRequest:IRequest<ResultOrderDto>
	{
		public int Id { get; set; }
		public GetByIdOrderingQueryRequest(int id)
		{
			Id = id;
		}
	}
}
