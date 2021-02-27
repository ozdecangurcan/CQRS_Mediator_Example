using CQRS_Mediator_Example.Models.RequestModels.QueryRequestModels;
using CQRS_Mediator_Example.Models.ResponseModels.QueryResponseModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Mediator_Example.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel,GetOrderByIdResponseModel>
    {
        public async Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request, CancellationToken cancellationToken)
        {
            var orderDetail = new GetOrderByIdResponseModel();
            //logic;
            return orderDetail;
        }
    }
}
