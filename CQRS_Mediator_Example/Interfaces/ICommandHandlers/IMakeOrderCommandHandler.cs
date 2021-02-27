using CQRS_Mediator_Example.Models.RequestModels.CommandRequestModels;
using CQRS_Mediator_Example.Models.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Example.Interfaces.ICommandHandlers
{
    public interface IMakeOrderCommandHandler
    {
        MakeOrderResponseModel MakeOrder(MakeOrderRequestModel requestModel);
    }
}
