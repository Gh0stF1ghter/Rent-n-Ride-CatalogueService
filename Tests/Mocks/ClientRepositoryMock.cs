using DAL.Entities;
using DAL.Repositories.Interfaces;
using Moq;
using System.Linq.Expressions;

namespace Tests.Mocks;

internal class ClientRepositoryMock : Mock<IClientRepository>
{
    private readonly CancellationToken _anyToken = It.IsAny<CancellationToken>();

    public void GetRange(IEnumerable<Client> clientsToReturn) =>
        Setup(cr => cr.GetRangeAsync(It.IsAny<int>(), It.IsAny<int>(), _anyToken))
            .ReturnsAsync(clientsToReturn);

    public void GetById(Client clientToReturn) =>
        Setup(cr => cr.GetByIdAsync(It.IsAny<Guid>(), _anyToken))
            .ReturnsAsync(clientToReturn);

    public void IsExists(bool boolToReturn) =>
        Setup(cr => cr.IsExistsAsync(It.IsAny<Expression<Func<Client, bool>>>(), _anyToken))
        .ReturnsAsync(boolToReturn);
}