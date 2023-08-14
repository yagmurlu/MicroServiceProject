using CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Commands;
using CasegmMicroservice.Serives.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Handlers
{
	public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest>
	{
		private readonly IRepository<Ordering> _repository;

		public CreateOrderCommandHandler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}

		public Task Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
		{
			var values = new Ordering()
			{
				UserID = request.UserID,
				OrderDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString()),
				TotalPrice = request.TotalPrice,
			};
			return _repository.CreateAsync(values);
		}
	}
}
