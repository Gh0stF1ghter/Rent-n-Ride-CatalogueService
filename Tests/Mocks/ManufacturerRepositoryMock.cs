using DAL.Entities;
using DAL.Repositories.Interfaces;
using Moq;
using System.Linq.Expressions;

namespace Tests.Mocks;

internal class ManufacturerRepositoryMock : Mock<IManufacturerRepository>
{
    private readonly CancellationToken _anyToken = It.IsAny<CancellationToken>();

    public void GetRange(IEnumerable<Manufacturer> manufacturersToReturn) =>
        Setup(cr => cr.GetRangeAsync(It.IsAny<int>(), It.IsAny<int>(), _anyToken))
            .ReturnsAsync(manufacturersToReturn);

    public void GetById(Manufacturer manufacturerToReturn) =>
        Setup(cr => cr.GetByIdAsync(It.IsAny<Guid>(), _anyToken))
            .ReturnsAsync(manufacturerToReturn);

    public void IsExists(bool boolToReturn) =>
        Setup(cr => cr.IsExistsAsync(It.IsAny<Expression<Func<Manufacturer, bool>>>(), _anyToken))
        .ReturnsAsync(boolToReturn);
}