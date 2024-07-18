using BLL.Services.Interfaces;
using CatalogGrpcService;
using Grpc.Core;
using Mapster;

namespace BLL.GrpcServices;

public class ManufacturerGrpcService(IManufacturerService service) : CatalogService.CatalogServiceBase
{
    public override async Task<GetManufacturersInRangeResponse> GetManufacturers(GetModelListRequest request, ServerCallContext context)
    {
        var dataList = await service.GetRangeAsync(request.PageNumber, request.PageSize, context.CancellationToken);

        var responseData = dataList.Adapt<IEnumerable<ProtoManufacturerModel>>();

        var response = new GetManufacturersInRangeResponse();

        response.Manufacturers.AddRange(responseData);

        return response;
    }

    public override async Task<GetManufacturerResponse> GetManufacturer(GetModelRequest request, ServerCallContext context)
    {
        var idIsValid = Guid.TryParse(request.Id, out var id);

        if (!idIsValid)
            throw new InvalidOperationException("Provided id is not GUID");

        var data = await service.GetByIdAsync(id, context.CancellationToken);

        var responseData = data.Adapt<ProtoManufacturerModel>();

        var response = new GetManufacturerResponse
        {
            Manufacturer = responseData
        };

        return response;
    }
}