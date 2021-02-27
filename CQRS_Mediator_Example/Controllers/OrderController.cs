using CQRS_Mediator_Example.Interfaces.ICommandHandlers;
using CQRS_Mediator_Example.Interfaces.IQueryHandlers;
using CQRS_Mediator_Example.Models.RequestModels.CommandRequestModels;
using CQRS_Mediator_Example.Models.RequestModels.QueryRequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        //private readonly IGetOrderByIdQueryHandler _getOrderByIdQueryHandler;
        //private readonly IMakeOrderCommandHandler _makeOrderCommandHandler;

        //public OrderController(
        //    IGetOrderByIdQueryHandler getOrderByIdQueryHandler,
        //    IMakeOrderCommandHandler makeOrderCommandHandler)
        //{
        //    _getOrderByIdQueryHandler = getOrderByIdQueryHandler;
        //    _makeOrderCommandHandler = makeOrderCommandHandler;
        //}

        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult MakeOrder([FromBody] MakeOrderRequestModel requestModel)
        {
            //var response = _makeOrderCommandHandler.MakeOrder(requestModel);
            var response = _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult OrderDetails([FromQuery] GetOrderByIdRequestModel requestModel)
        {
            //var response = _getOrderByIdQueryHandler.GetOrderById(requestModel);
            var response = _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
