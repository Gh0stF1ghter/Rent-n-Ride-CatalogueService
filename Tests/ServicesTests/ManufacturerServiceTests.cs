using BLL.Models;
using BLL.Services.Implementations;
using DAL.Entities;
using FluentAssertions;
using Mapster;
using Tests.DataGeneration;
using Tests.Mocks;

namespace Tests.ServicesTests;

public class ManufacturerServiceTests
{
    private readonly ManufacturerRepositoryMock _repositoryMock = new();

    private readonly List<Manufacturer> _manufacturers = DataGenerator.AddManufacturerData(5);

    public ManufacturerServiceTests()
    {
        _repositoryMock.GetRange(_manufacturers);
        _repositoryMock.GetById(_manufacturers[0]);
        _repositoryMock.IsExists(true);
    }

    [Fact]
    public async Task GetRangeAsync__ReturnsClientModelList()
    {
        //Arrange
        var correctModels = _manufacturers.Adapt<IEnumerable<ManufacturerModel>>();
        var service = new ManufacturerService(_repositoryMock.Object);

        //Act
        var response = await service.GetRangeAsync(1, 1, default);

        //Assert
        response.Should().BeEquivalentTo(correctModels);
    }

    [Fact]
    public async Task GetByIdAsync__ReturnsClientModel()
    {
        //Arrange
        var correctModel = _manufacturers[0].Adapt<ManufacturerModel>();
        var service = new ManufacturerService(_repositoryMock.Object);

        //Act
        var response = await service.GetByIdAsync(Guid.NewGuid(), default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task AddAsync_ClientModel_ReturnsClientModel()
    {
        //Arrange
        var correctModel = _manufacturers[0].Adapt<ManufacturerModel>();
        var service = new ManufacturerService(_repositoryMock.Object);

        //Act
        var response = await service.AddAsync(correctModel, default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task UpdateAsync_ClientModel_ReturnsClientModel()
    {
        //Arrange
        var correctUpdatedModel = _manufacturers[1].Adapt<ManufacturerModel>();
        var service = new ManufacturerService(_repositoryMock.Object);

        //Act
        var response = await service.UpdateAsync(correctUpdatedModel, default);

        //Assert
        response.Should().BeEquivalentTo(correctUpdatedModel);
    }

    [Fact]
    public async Task DeleteAsync_ClientId_()
    {
        //Arrange
        var service = new ManufacturerService(_repositoryMock.Object);

        //Act
        var response = async () => await service.DeleteAsync(Guid.NewGuid(), default);

        //Assert
        await response.Should().NotThrowAsync();
    }
}