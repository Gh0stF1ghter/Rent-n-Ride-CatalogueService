using BLL.Exceptions;
using BLL.Exceptions.ExceptionMessages;
using BLL.Services.Interfaces;
using CatalogGrpcService;
using Grpc.Core;
using Mapster;

namespace BLL.GrpcServices;

public class CarModelGrpcService(ICarModelService service) : CatalogService.CatalogServiceBase
{
    public override async Task<GetCarModelsInRangeResponse> GetCarModels(GetModelListRequest request, ServerCallContext context)
    {
        var dataList = await service.GetRangeAsync(request.PageNumber, request.PageSize, context.CancellationToken);

        var responseData = dataList.Adapt<IEnumerable<ProtoCarModel>>();

        var response = new GetCarModelsInRangeResponse();

        response.CarModels.AddRange(responseData);

        return response;
    }

    public override async Task<GetCarModelResponse> GetCarModel(GetModelRequest request, ServerCallContext context)
    {
        var idIsValid = Guid.TryParse(request.Id, out var id);

        if (!idIsValid)
            throw new InvalidOperationException("Provided id is not GUID");

        var data = await service.GetByIdAsync(id, context.CancellationToken);

        if (data is null)
            throw new NotFoundException(ExceptionMessages.NotFound(nameof(data), id));

        var responseData = data.Adapt<ProtoCarModel>();

        var response = new GetCarModelResponse
        {
            CarModel = responseData
        };

        return response;
    }
}
