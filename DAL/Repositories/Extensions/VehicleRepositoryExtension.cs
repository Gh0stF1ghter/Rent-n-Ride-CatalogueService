using DAL.Entities;
using DAL.QueryParameters;

namespace DAL.Repositories.Extensions;

public static class VehicleRepositoryExtension
{
    public static IQueryable<VehicleEntity> Filter(this IQueryable<VehicleEntity> vehicles, VehicleParameters? parameters) 
    {
        if (parameters is null)
            return vehicles;

        return vehicles.Where(v =>
                (v.CarModelId == parameters.CarModelId || !parameters.CarModelId.HasValue)
                && (v.FuelType == parameters.FuelType || !parameters.FuelType.HasValue)
                && (v.VehicleType == parameters.VehicleType || !parameters.VehicleType.HasValue)
                && (v.VehicleState == parameters.VehicleState || !parameters.VehicleState.HasValue)
            );
    }
}
