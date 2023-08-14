using AutoMapper;
using CasegmMicroservice.Serives.Order.Core.Application.Dtos.AddressDtos;
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
	public class GetAllOrderingQueryHandler : IRequestHandler<GetAllOrderingQueryRequest, List<ResultOrderDto>>
	{
		private readonly IMapper _mapper;
		private readonly IRepository<Ordering> _repository;

		public GetAllOrderingQueryHandler(IMapper mapper, IRepository<Ordering> repository)
		{
			_mapper = mapper;
			_repository = repository;
		}

		public async Task<List<ResultOrderDto>> Handle(GetAllOrderingQueryRequest request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return _mapper.Map<List<ResultOrderDto>>(values);
		}
	}
}
