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
	public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQueryRequest, List<ResultAddressDto>>
	{
		private readonly IMapper _mapper;
		private readonly IRepository<Address> _repository;

		public GetAllAddressQueryHandler(IMapper mapper, IRepository<Address> repository)
		{
			_mapper = mapper;
			_repository = repository;
		}

		public async Task<List<ResultAddressDto>> Handle(GetAllAddressQueryRequest request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return _mapper.Map<List<ResultAddressDto>>(values);
		}
	}
}
