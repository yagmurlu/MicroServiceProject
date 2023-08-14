using CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Commands;
using CasegmMicroservice.Serives.Order.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> OrderingList()
        {
            var values = await _mediator.Send(new GetAllOrderingQueryRequest());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> OrderingGetById(int id)
        {
            var value = await _mediator.Send(new GetByIdOrderingQueryRequest(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> OrderingCreate(CreateOrderCommandRequest createOrderCommandRequest)
        {
            await _mediator.Send(createOrderCommandRequest);
            return Ok("Sipariş Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> OrderingUpdate(UpdateOrderCommandRequest updateOrderCommandRequest)
        {
            await _mediator.Send(updateOrderCommandRequest);
            return Ok("Sipariş Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> OrderingDelete(int id)
        {
            await _mediator.Send(new RemoveOrderingCommandRequest(id));
            return Ok("Sipariş Silindi");
        }
    }
}
