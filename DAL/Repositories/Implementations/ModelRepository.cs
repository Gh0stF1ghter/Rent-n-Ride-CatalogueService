using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;
public class ModelRepository(AgencyDbContext context) : IModelRepository
{
    public async Task<IEnumerable<Model>> GetModelsRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = page - 1 * pageSize;

        return await context.Models.Skip(rowsToSkip).Take(pageSize).AsNoTracking().ToListAsync(cancellationToken);
    }
    public async Task<Model?> GetModelByIdAsync(int id, CancellationToken cancellationToken) =>
        await context.Models.FindAsync([id], cancellationToken);

    public async Task<bool> IsModelExists(Expression<Func<Model, bool>> predicate, CancellationToken cancellationToken) =>
        await context.Models.AnyAsync(predicate, cancellationToken);

    public void AddModel(Model model) =>
        context.Models.Add(model);
    public void RemoveModel(Model model) =>
        context.Models.Remove(model);

}
