using AutoMapper;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.AddressDtos;
using CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Queries;
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
	public class GetByIdAddressQueryHandler : IRequestHandler<GetByIdAddressQueryRequest, ResultAddressDto>
	{
		private readonly IMapper _mapper;
		private readonly IRepository<OrderDetail> _repository;

		public GetByIdAddressQueryHandler(IMapper mapper, IRepository<OrderDetail> repository)
		{
			_mapper = mapper;
			_repository = repository;
		}

		public async Task<ResultAddressDto> Handle(GetByIdAddressQueryRequest request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return _mapper.Map<ResultAddressDto>(values);
		}
	}
}
