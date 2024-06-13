using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Mapster;

namespace BLL.Services.Implementations;

public class ManufacturerService(IManufacturerRepository repository) : IManufacturerService
{
    public async Task<IEnumerable<ManufacturerModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var manufacturers = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var manufacturerModels = manufacturers.Adapt<IEnumerable<ManufacturerModel>>();

        return manufacturerModels;
    }

    public async Task<ManufacturerModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(id, cancellationToken);

        var manufacturerModel = manufacturer.Adapt<ManufacturerModel>();

        return manufacturerModel;
    }

    public async Task<ManufacturerModel> AddAsync(ManufacturerModel manufacturerModel, CancellationToken cancellationToken)
    {
        var manufacturer = manufacturerModel.Adapt<ManufacturerEntity>();

        await repository.AddAsync(manufacturer, cancellationToken);

        var newManufacturerModel = manufacturer.Adapt<ManufacturerModel>();

        return newManufacturerModel;
    }

    public async Task<ManufacturerModel> UpdateAsync(ManufacturerModel newManufacturerModel, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(newManufacturerModel.Id, cancellationToken);

        newManufacturerModel.Adapt(manufacturer);

        await repository.UpdateAsync(manufacturer, cancellationToken);

        var manufacturerToReturn = manufacturer.Adapt<ManufacturerModel>();

        return manufacturerToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(id, cancellationToken);

        await repository.RemoveAsync(manufacturer, cancellationToken);
    }
}