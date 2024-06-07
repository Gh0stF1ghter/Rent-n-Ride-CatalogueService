using BLL.ViewModels;

namespace BLL.Services.Interfaces;

public interface IManufacturerService
{
    Task<IEnumerable<ManufacturerViewModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ManufacturerViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<ManufacturerViewModel> AddAsync(CreateManufacturerViewModel manufacturerModel, CancellationToken cancellationToken);

    Task UpdateAsync(Guid id, CreateManufacturerViewModel newManufacturerModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
