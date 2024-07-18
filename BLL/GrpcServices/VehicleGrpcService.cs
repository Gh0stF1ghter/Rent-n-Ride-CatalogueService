using BLL.Services.Interfaces;
using CatalogGrpcService;
using Grpc.Core;
using Mapster;

namespace BLL.GrpcServices;

public class VehicleGrpcService(IVehicleService service) : CatalogService.CatalogServiceBase
{
    public override async Task<GetVehiclesInRangeResponse> GetVehicles(GetModelListRequest request, ServerCallContext context)
    {
        var dataList = await service.GetRangeAsync(request.PageNumber, request.PageSize, context.CancellationToken);

        var responseData = dataList.Adapt<IEnumerable<ProtoVehicleModel>>();

        var response = new GetVehiclesInRangeResponse();

        response.Vehicles.AddRange(responseData);

        return response;
    }

    public override async Task<GetVehicleResponse> GetVehicle(GetModelRequest request, ServerCallContext context)
    {
        var idIsValid = Guid.TryParse(request.Id, out var id);

        if (!idIsValid)
            throw new InvalidOperationException("Provided id is not GUID");

        var data = await service.GetByIdAsync(id, context.CancellationToken);

        var responseData = data.Adapt<ProtoVehicleModel>();

        var response = new GetVehicleResponse
        {
            Vehicle = responseData
        };

        return response;
    }
}