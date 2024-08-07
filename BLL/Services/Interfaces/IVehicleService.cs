﻿using BLL.Models;
using DAL.QueryParameters;

namespace BLL.Services.Interfaces;

public interface IVehicleService
{
    Task<IEnumerable<VehicleModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken, VehicleParameters? parameters = default);

    Task<VehicleModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<VehicleModel> AddAsync(VehicleModel vehicleModel, CancellationToken cancellationToken);

    Task<VehicleModel> UpdateAsync(VehicleModel newVehicleModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}