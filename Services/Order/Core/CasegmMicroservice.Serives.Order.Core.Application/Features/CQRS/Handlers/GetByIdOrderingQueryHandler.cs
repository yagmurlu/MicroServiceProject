using AutoMapper;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderDetailDtos;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderingDtos;
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
	public class GetByIdOrderingQueryHandler : IRequestHandler<GetByIdOrderingQueryRequest, ResultOrderDto>
	{
		private readonly IRepository<Ordering> _repository;
		private readonly IMapper _mapper;

		public GetByIdOrderingQueryHandler(IRepository<Ordering> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<ResultOrderDto> Handle(GetByIdOrderingQueryRequest request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			return _mapper.Map<ResultOrderDto>(value);

		}
	}
}
