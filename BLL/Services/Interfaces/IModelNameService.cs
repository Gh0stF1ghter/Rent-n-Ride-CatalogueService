using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces;

internal interface IModelNameService
{
    Task<IEnumerable<ModelNameModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ModelNameModel> GetByIdAsync(int id, CancellationToken cancellationToken);

    Task<ModelNameModel> AddAsync(ModelNameModel modelNameModel, CancellationToken cancellationToken);

    Task UpdateAsync(int id, ModelNameModel newModelNameModel);

    Task DeleteAsync(int id);
}
