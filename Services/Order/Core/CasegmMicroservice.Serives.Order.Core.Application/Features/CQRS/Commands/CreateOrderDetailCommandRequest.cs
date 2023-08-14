using CasegmMicroservice.Serives.Order.Core.Application.Dtos.AddressDtos;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderDetailDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Commands
{
	public class CreateOrderDetailCommandRequest : IRequest
	{
		public string ProductID { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int ProductAmount { get; set; }
		public int OrderingID { get; set; }
	}
}
