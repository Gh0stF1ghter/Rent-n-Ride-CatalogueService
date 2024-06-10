using DAL.Models;

namespace BLL.Services.Interfaces;

public interface IVehicleClientHistoryService
{
    Task<IEnumerable<VchModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VchModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<VchModel> AddAsync(VchModel vchModel, CancellationToken cancellationToken);

    Task<VchModel> UpdateAsync(VchModel vchModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}