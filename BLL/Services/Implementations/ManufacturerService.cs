using BLL.Services.Interfaces;
using BLL.ViewModels;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Mapster;

namespace BLL.Services.Implementations;

public class ManufacturerService(IManufacturerRepository repository) : IManufacturerService
{
    public async Task<IEnumerable<ManufacturerViewModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var manufacturers = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var manufacturerModels = manufacturers.Adapt<IEnumerable<ManufacturerViewModel>>();

        return manufacturerModels;
    }

    public async Task<ManufacturerViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(id, false, cancellationToken);

        var manufacturerModel = manufacturer.Adapt<ManufacturerViewModel>();

        return manufacturerModel;
    }

    public async Task<ManufacturerViewModel> AddAsync(CreateManufacturerViewModel manufacturerModel, CancellationToken cancellationToken)
    {
        var manufacturer = manufacturerModel.Adapt<Manufacturer>();

        await repository.AddAsync(manufacturer, cancellationToken);

        var newManufacturerModel = manufacturer.Adapt<ManufacturerViewModel>();

        return newManufacturerModel;
    }

    public async Task UpdateAsync(Guid id, CreateManufacturerViewModel newManufacturerModel, CancellationToken cancellationToken)
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