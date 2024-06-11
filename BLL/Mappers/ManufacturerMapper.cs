using BLL.Models;
using DAL.Entities;

namespace BLL.Mappers;

internal static class ManufacturerMapper
{
    public static Manufacturer Map(ManufacturerModel manufacturerModel) =>
        new()
        {
            Id = manufacturerModel.Id,
            Name = manufacturerModel.Name,
            ModelNames = manufacturerModel.ModelNames,
        };

    public static ManufacturerModel Map(Manufacturer manufacturer) =>
        new(
            Id: manufacturer.Id,
            Name: manufacturer.Name,
            ModelNames: manufacturer.ModelNames
            );
}