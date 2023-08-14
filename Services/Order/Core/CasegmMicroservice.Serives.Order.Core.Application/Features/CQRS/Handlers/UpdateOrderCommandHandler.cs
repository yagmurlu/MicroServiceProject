using CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Commands;
using CasegmMicroservice.Serives.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Handlers
{
	public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest>
	{
		private readonly IRepository<Ordering> _repository;

        public UpdateOrderCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.OrderingID);
			values.UserID= request.UserID;
			values.TotalPrice= request.TotalPrice;
			values.OrderDate= request.OrderDate;
			await _repository.UpdateAsync(values);
		}
	}
}
