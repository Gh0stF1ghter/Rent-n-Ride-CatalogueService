using BLL.Exceptions;
using BLL.Models;
using BLL.Services.Implementations;
using DAL.Entities;
using FluentAssertions;
using Mapster;
using Newtonsoft.Json;
using System.Text;
using Tests.DataGeneration;
using Tests.Mocks;

namespace Tests.ServicesTests;

public class ManufacturerServiceTests
{
    private readonly ManufacturerRepositoryMock _repositoryMock = new();

    private readonly DistributedCacheMock _distributedCacheMock = new();

    private readonly List<ManufacturerEntity> _manufacturers = DataGenerator.AddManufacturerData(5);

    public ManufacturerServiceTests()
    {
        _repositoryMock.GetRange(_manufacturers);
        _repositoryMock.GetById(_manufacturers[0]);
        _repositoryMock.IsExists(true);
    }

    [Fact]
    public async Task GetRangeAsync__ReturnsManufacturerModelList()
    {
        //Arrange
        var correctModels = _manufacturers.Adapt<IEnumerable<ManufacturerModel>>();

        var service = new ManufacturerService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetRangeAsync(1, 1, default);

        //Assert
        response.Should().BeEquivalentTo(correctModels);
    }

    [Fact]
    public async Task GetByIdAsync__ReturnsManufacturerModel()
    {
        //Arrange
        var correctModel = _manufacturers[0].Adapt<ManufacturerModel>();

        var serializedModel = JsonConvert.SerializeObject(correctModel);
        var cachedModel = Encoding.UTF8.GetBytes(serializedModel);
        _distributedCacheMock.GetDataFromCache(cachedModel);

        var service = new ManufacturerService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetByIdAsync(Guid.NewGuid(), default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task GetByIdAsync_EmptyCache_ReturnsClientModel()
    {
        //Arrange
        var correctModel = _manufacturers[0].Adapt<ManufacturerModel>();

        var serializedModel = JsonConvert.SerializeObject(null);
        var cachedModel = Encoding.UTF8.GetBytes(serializedModel);
        _distributedCacheMock.GetDataFromCache(cachedModel);

        var service = new ManufacturerService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetByIdAsync(Guid.NewGuid(), default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task AddAsync_ManufacturerModel_ReturnsManufacturerModel()
    {
        //Arrange
        var correctModel = _manufacturers[0].Adapt<ManufacturerModel>();
        var service = new ManufacturerService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.AddAsync(correctModel, default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task UpdateAsync_ManufacturerModel_ReturnsManufacturerModel()
    {
        //Arrange
        var correctUpdatedModel = _manufacturers[1].Adapt<ManufacturerModel>();
        var service = new ManufacturerService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.UpdateAsync(correctUpdatedModel, default);

        //Assert
        response.Should().BeEquivalentTo(correctUpdatedModel);
    }

    [Fact]
    public async Task UpdateAsync_InvalidId_ThrowsNotFoundException()
    {
        //Arrange
        _repositoryMock.GetById(null);

        var correctUpdatedModel = _manufacturers[1].Adapt<ManufacturerModel>();
        var service = new ManufacturerService(_repositoryMock.Object);

        //Act
        var response = async () => await service.UpdateAsync(correctUpdatedModel, default);

        //Assert
        await response.Should().ThrowAsync<NotFoundException>();
    }

    [Fact]
    public async Task DeleteAsync_ManufacturerId_()
    {
        //Arrange
        var service = new ManufacturerService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = async () => await service.DeleteAsync(Guid.NewGuid(), default);

        //Assert
        await response.Should().NotThrowAsync();
    }

    [Fact]
    public async Task DeleteAsync_InvalidId_ThrowsNotFoundException()
    {
        //Arrange
        _repositoryMock.GetById(null);

        var service = new ManufacturerService(_repositoryMock.Object);

        //Act
        var response = async () => await service.DeleteAsync(Guid.NewGuid(), default);

        //Assert
        await response.Should().ThrowAsync<NotFoundException>();
    }
}