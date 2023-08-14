using CasegmMicroservice.Serives.Order.Core.Application.Dtos.AddressDtos;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderingDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Commands
{
	public class CreateOrderCommandRequest : IRequest
	{
		public string UserID { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime OrderDate { get; set; }
	}
}
