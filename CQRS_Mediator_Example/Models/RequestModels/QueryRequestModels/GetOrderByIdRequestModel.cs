using CQRS_Mediator_Example.Models.ResponseModels.QueryResponseModels;
using MediatR;
using System;

namespace CQRS_Mediator_Example.Models.RequestModels.QueryRequestModels
{
    public class GetOrderByIdRequestModel : IRequest<GetOrderByIdResponseModel>
    {
        public Guid OrderId { get; set; }
    }
}
