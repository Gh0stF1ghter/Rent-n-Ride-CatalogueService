using BLL.Services.Interfaces;
using CatalogGrpcService;
using Grpc.Core;
using Mapster;

namespace BLL.GrpcServices;

public class CatalogGrpcServiceController(
    ICarModelService carModelService,
    IManufacturerService manufacturerService,
    IVehicleService vehicleService
    ) : CatalogService.CatalogServiceBase
{
    public override async Task<GetCarModelsInRangeResponse> GetCarModels(GetModelListRequest request, ServerCallContext context)
    {
        var dataList = await carModelService.GetRangeAsync(request.PageNumber, request.PageSize, context.CancellationToken);

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

        var data = await carModelService.GetByIdAsync(id, context.CancellationToken);

        var responseData = data.Adapt<ProtoCarModel>();

        var response = new GetCarModelResponse
        {
            CarModel = responseData
        };

        return response;
    }

    public override async Task<GetManufacturersInRangeResponse> GetManufacturers(GetModelListRequest request, ServerCallContext context)
    {
        var dataList = await manufacturerService.GetRangeAsync(request.PageNumber, request.PageSize, context.CancellationToken);

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

        var data = await manufacturerService.GetByIdAsync(id, context.CancellationToken);

        var responseData = data.Adapt<ProtoManufacturerModel>();

        var response = new GetManufacturerResponse
        {
            Manufacturer = responseData
        };

        return response;
    }

    public override async Task<GetVehiclesInRangeResponse> GetVehicles(GetModelListRequest request, ServerCallContext context)
    {
        var dataList = await vehicleService.GetRangeAsync(request.PageNumber, request.PageSize, context.CancellationToken);

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

        var data = await vehicleService.GetByIdAsync(id, context.CancellationToken);

        var responseData = data.Adapt<ProtoVehicleModel>();

        var response = new GetVehicleResponse
        {
            Vehicle = responseData
        };

        return response;
    }
}