using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces;
public interface IVehicleRepository
{
    public Task<IEnumerable<Vehicle>> GetVehiclesRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<Vehicle?> GetVehicleByIdAsync(int id, CancellationToken cancellationToken);

    public Task<bool> IsVehicleExists(Expression<Func<Client, bool>> predicate, CancellationToken cancellationToken);

    public void AddVehicle(Vehicle vehicle);
    public void RemoveVehicle(Vehicle vehicle);
}