using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Commands
{
	public class RemoveOrderingCommandRequest:IRequest
	{
		public int Id { get; set; }
		public RemoveOrderingCommandRequest(int ıd)
		{
			Id = ıd;
		}
	}
}
