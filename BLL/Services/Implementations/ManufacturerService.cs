using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Models;
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
        var manufacturer = await repository.GetByIdAsync(id, false, cancellationToken);

        var manufacturerModel = manufacturer.Adapt<ManufacturerModel>();

        return manufacturerModel;
    }

    public async Task<ManufacturerModel> AddAsync(ManufacturerModel manufacturerModel, CancellationToken cancellationToken)
    {
        var manufacturer = manufacturerModel.Adapt<Manufacturer>();

        await repository.AddAsync(manufacturer, cancellationToken);

        var newManufacturerModel = manufacturer.Adapt<ManufacturerModel>();

        return newManufacturerModel;
    }

    public async Task UpdateAsync(Guid id, ManufacturerModel newManufacturerModel, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(id, true, cancellationToken);

        newManufacturerModel.Adapt(manufacturer);

        await repository.UpdateAsync(manufacturer, cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(id, true, cancellationToken);

        repository.RemoveAsync(manufacturer, cancellationToken);
    }
}