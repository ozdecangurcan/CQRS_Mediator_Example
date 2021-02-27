using CQRS_Mediator_Example.Models.RequestModels.QueryRequestModels;
using CQRS_Mediator_Example.Models.ResponseModels.QueryResponseModels;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Mediator_Example.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel, GetOrderByIdResponseModel>
    {
        public async Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request, CancellationToken cancellationToken)
        {
            var orderDetail = new GetOrderByIdResponseModel()
            {
                Amount = 3,
                DateOrder = DateTime.Now,
                OrderId = request.OrderId,
                OrderName = "Playstation 5",
                OrderPersonId = Guid.NewGuid(),
                OrderPersonName = "Özdecan GÜRCAN",
                ProductId = Guid.NewGuid(),
                ProductName = "Playstation 5",
                Quantity = 1
            };

            return orderDetail;
        }
    }
}
