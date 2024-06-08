using BLL.Services.Interfaces;
using DAL.Mappers;
using DAL.Models;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementations;

public class ManufacturerService(IManufacturerRepository repository) : IManufacturerService
{
    public async Task<IEnumerable<ManufacturerModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var manufacturers = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var manufacturerModels = new List<ManufacturerModel>();

        foreach (var manufacturer in manufacturers)
        {
            var manufacturerModel = ManufacturerMapper.Map(manufacturer);

            manufacturerModels.Add(manufacturerModel);
        }

        return manufacturerModels;
    }

    public async Task<ManufacturerModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(id, false, cancellationToken);

        var manufacturerModel = ManufacturerMapper.Map(manufacturer);

        return manufacturerModel;
    }

    public async Task<ManufacturerModel> AddAsync(ManufacturerModel manufacturerModel, CancellationToken cancellationToken)
    {
        var manufacturer = ManufacturerMapper.Map(manufacturerModel);

        await repository.AddAsync(manufacturer, cancellationToken);

        var newManufacturerModel = ManufacturerMapper.Map(manufacturer);

        return newManufacturerModel;
    }

    public async Task UpdateAsync(Guid id, ManufacturerModel newManufacturerModel, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(id, true, cancellationToken);

        manufacturer = ManufacturerMapper.Map(newManufacturerModel);

        await repository.UpdateAsync(manufacturer, cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(id, true, cancellationToken);

        await repository.RemoveAsync(manufacturer, cancellationToken);
    }
}