using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces;
internal interface IManufacturerService
{
    Task<IEnumerable<ManufacturerModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ManufacturerModel> GetByIdAsync(int id, CancellationToken cancellationToken);

    Task<ManufacturerModel> AddAsync(ManufacturerModel manufacturerModel, CancellationToken cancellationToken);

    Task UpdateAsync(int id, ManufacturerModel newManufacturerModel);

    Task DeleteAsync(int id);
}
