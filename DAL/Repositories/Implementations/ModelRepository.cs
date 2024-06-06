using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;
public class ModelRepository(AgencyDbContext context) : IModelRepository
{
    public async Task<IEnumerable<Model>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = page - 1 * pageSize;

        return await context.Models.Skip(rowsToSkip).Take(pageSize).AsNoTracking().ToListAsync(cancellationToken);
    }
    public async Task<Model?> GetByIdAsync(int id, CancellationToken cancellationToken) =>
        await context.Models.FindAsync([id], cancellationToken);

    public async Task<bool> IsExistsAsync(Expression<Func<Model, bool>> predicate, CancellationToken cancellationToken) =>
        await context.Models.AnyAsync(predicate, cancellationToken);

    public async Task AddAsync(Model model, CancellationToken cancellationToken)
    {
        await context.Models.AddAsync(model, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
    public async Task RemoveAsync(Model model, CancellationToken cancellationToken) 
    {
        context.Models.Remove(model);
        await context.SaveChangesAsync(cancellationToken);
    }
}
