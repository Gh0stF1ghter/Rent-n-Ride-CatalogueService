using BLL.Models;

namespace BLL.Services.Interfaces;

public interface IManufacturerService
{
    Task<IEnumerable<ManufacturerModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ManufacturerModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<ManufacturerModel> AddAsync(ManufacturerModel manufacturerModel, CancellationToken cancellationToken);

    Task<ManufacturerModel> UpdateAsync(ManufacturerModel newManufacturerModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
