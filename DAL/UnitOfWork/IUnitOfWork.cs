using DAL.Repositories.Interfaces;

namespace DAL.UnitOfWork;
public interface IUnitOfWork : IDisposable
{
    IClientRepository Client { get; }
    IManufacturerRepository Manufacturer { get; }
    IModelRepository Model { get; }
    IVehicleClientHistoryRepository VehicleClientHistory { get; }
    IVehicleRepository Vehicle { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}