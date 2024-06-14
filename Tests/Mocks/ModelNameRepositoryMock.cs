using DAL.Entities;
using DAL.Repositories.Interfaces;
using Moq;
using System.Linq.Expressions;

namespace Tests.Mocks;

internal class ModelNameRepositoryMock : Mock<IModelNameRepository>
{
    private readonly CancellationToken _anyToken = It.IsAny<CancellationToken>();

    public void GetRange(IEnumerable<ModelName> modelNamesToReturn) =>
        Setup(cr => cr.GetRangeAsync(It.IsAny<int>(), It.IsAny<int>(), _anyToken))
            .ReturnsAsync(modelNamesToReturn);

    public void GetById(ModelName modelNameToReturn) =>
        Setup(cr => cr.GetByIdAsync(It.IsAny<Guid>(), It.IsAny<bool>(), _anyToken))
            .ReturnsAsync(modelNameToReturn);

    public void IsExists(bool boolToReturn) =>
        Setup(cr => cr.IsExistsAsync(It.IsAny<Expression<Func<ModelName, bool>>>(), _anyToken))
        .ReturnsAsync(boolToReturn);
}