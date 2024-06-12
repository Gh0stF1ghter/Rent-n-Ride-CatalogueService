using BLL.Models;
using BLL.Services.Implementations;
using DAL.Entities;
using FluentAssertions;
using Mapster;
using Tests.DataGeneration;
using Tests.Mocks;

namespace Tests.UnitTests;

public class ClientServiceTests
{
    private readonly ClientRepositoryMock _repositoryMock = new();

    private readonly List<Client> _clients = DataGenerator.AddClientData(5);

    public ClientServiceTests()
    {
        _repositoryMock.GetRange(_clients);
        _repositoryMock.GetById(_clients[0]);
        _repositoryMock.IsExists(true);
    }

    [Fact]
    public async Task GetRangeAsync__ReturnsClientModelList()
    {
        //Arrange
        var correctClientModels = _clients.Adapt<IEnumerable<ClientModel>>();
        var service = new ClientService(_repositoryMock.Object);

        //Act
        var response = await service.GetRangeAsync(1, 1, default);
        
        //Assert
        response.Should().BeEquivalentTo(correctClientModels);
    }

    [Fact]
    public async Task GetByIdAsync__ReturnsClientModel()
    {
        //Arrange
        //Act
        //Assert
    }

    [Fact]
    public async Task AddAsync_ClientModel_ReturnsClientModel()
    {
        //Arrange
        //Act
        //Assert
    }

    [Fact]
    public async Task UpdateAsync_ClientModel_ReturnsClientModel()
    {
        //Arrange
        //Act
        //Assert
    }

    [Fact]
    public async Task DeleteAsync_ClientId()
    {
        //Arrange
        //Act
        //Assert
    }
}