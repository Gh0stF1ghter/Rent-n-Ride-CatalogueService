using DAL.Entities;
using DAL.Models;

namespace DAL.Mappers;

internal static class ModelMapper
{
    public static ModelName Map(ModelNameModel modelModel) =>
        new()
        {
            Id = modelModel.Id,
            Name = modelModel.Name,
            Manufacturer = modelModel.Manufacturer,
            Vehicles = modelModel.Vehicles
        };

    public static ModelNameModel Map(ModelName model) =>
        new(
            Id: model.Id,
            Name: model.Name,
            Manufacturer: model.Manufacturer,
            Vehicles: model.Vehicles
            );
}