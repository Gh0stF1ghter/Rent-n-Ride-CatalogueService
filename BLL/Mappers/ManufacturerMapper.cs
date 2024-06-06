using DAL.Entities;
using DAL.Models;

namespace DAL.Mappers;

internal static class ManufacturerMapper
{
    public static Manufacturer Map(ManufacturerModel manufacturerModel) =>
        new()
        {
            Id = manufacturerModel.Id,
            Name = manufacturerModel.Name,
            Models = manufacturerModel.Models,
        };

    public static ManufacturerModel Map(Manufacturer manufacturer) =>
        new(
            Id: manufacturer.Id,
            Name: manufacturer.Name,
            Models:manufacturer.Models
            );
}