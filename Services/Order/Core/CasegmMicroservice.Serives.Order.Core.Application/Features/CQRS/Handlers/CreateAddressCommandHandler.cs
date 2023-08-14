using AutoMapper;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.AddressDtos;
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
	public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest>
	{
		private readonly IRepository<Address> _repository;

		public CreateAddressCommandHandler(IRepository<Address> repository)
		{
			_repository = repository;
		}

		public Task Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
		{
			var values = new Address()
			{
				City = request.City,
				Detail = request.Detail,
				District = request.District,
				UserID = request.UserID,
			};
			return _repository.CreateAsync(values);
		}
	}
}
