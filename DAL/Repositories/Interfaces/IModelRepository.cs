using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;
public interface IModelRepository
{
    public Task<IEnumerable<Model>> GetModelsRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<Model?> GetModelByIdAsync(int id, CancellationToken cancellationToken);

    public Task<bool> IsModelExists(Expression<Func<Model, bool>> predicate, CancellationToken cancellationToken);

    public void AddModel(Model model);
    public void RemoveModel(Model model);
}