using DAL.Entities;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces;
internal interface IVehicleClientHistoryService
{
    Task<IEnumerable<VchModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VchModel> GetByIdAsync(int id, CancellationToken cancellationToken);

    Task<VchModel> AddAsync(VchModel vchModel, CancellationToken cancellationToken);

    Task UpdateAsync(int id, VchModel newVchModel);

    Task DeleteAsync(int id);
}