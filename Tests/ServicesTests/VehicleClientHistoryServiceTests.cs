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
public class VehicleClientHistoryServiceTests
{
    private readonly VehicleClientHistoryRepositoryMock _repositoryMock = new();

    private readonly DistributedCacheMock _distributedCacheMock = new();

    private readonly List<VehicleClientHistoryEntity> _vehicleClientHistories = DataGenerator.AddVehicleClientHistoryData(5);

    public VehicleClientHistoryServiceTests()
    {
        _repositoryMock.GetRange(_vehicleClientHistories);
        _repositoryMock.GetById(_vehicleClientHistories[0]);
        _repositoryMock.IsExists(true);
    }

    [Fact]
    public async Task GetRangeAsync__ReturnsClientModelList()
    {
        //Arrange
        var correctModels = _vehicleClientHistories.Adapt<IEnumerable<VehicleClientHistoryModel>>();

        var serializedModel = JsonConvert.SerializeObject(correctModels);
        var cachedModel = Encoding.UTF8.GetBytes(serializedModel);
        _distributedCacheMock.GetDataFromCache(cachedModel);

        var service = new VehicleClientHistoryService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetRangeAsync(1, 1, default);

        //Assert
        response.Should().BeEquivalentTo(correctModels);
    }

    [Fact]
    public async Task GetRangeAsync_EmptyCache_ReturnsClientModelList()
    {
        //Arrange
        var correctModels = _vehicleClientHistories.Adapt<IEnumerable<VehicleClientHistoryModel>>();

        var serializedModel = JsonConvert.SerializeObject(null);
        var cachedModel = Encoding.UTF8.GetBytes(serializedModel);
        _distributedCacheMock.GetDataFromCache(cachedModel);

        var service = new VehicleClientHistoryService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetRangeAsync(1, 1, default);

        //Assert
        response.Should().BeEquivalentTo(correctModels);
    }

    [Fact]
    public async Task GetByIdAsync__ReturnsClientModel()
    {
        //Arrange
        var correctModel = _vehicleClientHistories[0].Adapt<VehicleClientHistoryModel>();

        var serializedModel = JsonConvert.SerializeObject(correctModel);
        var cachedModel = Encoding.UTF8.GetBytes(serializedModel);
        _distributedCacheMock.GetDataFromCache(cachedModel);

        var service = new VehicleClientHistoryService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetByIdAsync(Guid.NewGuid(), default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task GetByIdAsync_EmptyCache_ReturnsClientModel()
    {
        //Arrange
        var correctModel = _vehicleClientHistories[0].Adapt<VehicleClientHistoryModel>();

        var serializedModel = JsonConvert.SerializeObject(null);
        var cachedModel = Encoding.UTF8.GetBytes(serializedModel);
        _distributedCacheMock.GetDataFromCache(cachedModel);

        var service = new VehicleClientHistoryService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetByIdAsync(Guid.NewGuid(), default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task AddAsync_ClientModel_ReturnsClientModel()
    {
        //Arrange
        var correctModel = _vehicleClientHistories[0].Adapt<VehicleClientHistoryModel>();
        var service = new VehicleClientHistoryService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.AddAsync(correctModel, default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task UpdateAsync_ClientModel_ReturnsClientModel()
    {
        //Arrange
        var correctUpdatedModel = _vehicleClientHistories[1].Adapt<VehicleClientHistoryModel>();
        var service = new VehicleClientHistoryService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.UpdateAsync(correctUpdatedModel, default);

        //Assert
        response.Should().BeEquivalentTo(correctUpdatedModel);
    }

    [Fact]
    public async Task DeleteAsync_ClientId_()
    {
        //Arrange
        var service = new VehicleClientHistoryService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = async () => await service.DeleteAsync(Guid.NewGuid(), default);

        //Assert
        await response.Should().NotThrowAsync();
    }
}