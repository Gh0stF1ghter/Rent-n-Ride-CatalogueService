using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;
public interface IVehicleRepository
{
    public Task<IEnumerable<Vehicle>> GetVehiclesRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<Vehicle?> GetVehicleByIdAsync(int id, CancellationToken cancellationToken);

    public Task<bool> IsVehicleExists(Expression<Func<Vehicle, bool>> predicate, CancellationToken cancellationToken);

    public void AddVehicle(Vehicle vehicle);
    public void RemoveVehicle(Vehicle vehicle);
}