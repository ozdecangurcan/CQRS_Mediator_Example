using CQRS_Mediator_Example.Models.RequestModels.QueryRequestModels;
using CQRS_Mediator_Example.Models.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Example.Interfaces.IQueryHandlers
{
    public interface IGetOrderByIdQueryHandler
    {
        GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel);
    }
}
