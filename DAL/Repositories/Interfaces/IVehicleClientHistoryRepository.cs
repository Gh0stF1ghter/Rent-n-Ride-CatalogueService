using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;
public interface IVehicleClientHistoryRepository
{
    public Task<IEnumerable<VehicleClientHistory>> GetVehicleClientHistoriesRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<VehicleClientHistory?> GetVehicleClientHistoryByIdAsync(int id, CancellationToken cancellationToken);

    public Task<bool> IsVehicleClientHistoryExists(Expression<Func<VehicleClientHistory, bool>> predicate, CancellationToken cancellationToken);

    public void AddVehicleClientHistory(VehicleClientHistory vehicleClientHistory);
    public void RemoveVehicleClientHistory(VehicleClientHistory vehicleClientHistory);
}