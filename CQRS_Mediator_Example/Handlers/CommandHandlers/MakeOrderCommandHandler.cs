using CQRS_Mediator_Example.Models.RequestModels.CommandRequestModels;
using CQRS_Mediator_Example.Models.ResponseModels.CommandResponseModels;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Mediator_Example.Handlers.CommandHandlers
{
    public class MakeOrderCommandHandler : IRequestHandler<MakeOrderRequestModel, MakeOrderResponseModel>
    {
        public async Task<MakeOrderResponseModel> Handle(MakeOrderRequestModel request, CancellationToken cancellationToken)
        {
            var result = new MakeOrderResponseModel
            {
                IsSuccess = true,
                OrderId = request.OrderId
            };

            return result;
        }
    }
}
