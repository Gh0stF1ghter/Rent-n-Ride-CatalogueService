using BLL.Models;

namespace BLL.Services.Interfaces;

public interface ICarModelService
{
    Task<IEnumerable<CarModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<CarModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<CarModel> AddAsync(CarModel modelNameModel, CancellationToken cancellationToken);

    Task<CarModel> UpdateAsync(CarModel newModelNameModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
