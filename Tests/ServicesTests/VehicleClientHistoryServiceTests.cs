using BLL.Exceptions;
using BLL.Models;
using BLL.Services.Implementations;
using DAL.Entities;
using FluentAssertions;
using Mapster;
using Tests.DataGeneration;
using Tests.Mocks;

namespace Tests.ServicesTests;
public class VehicleClientHistoryServiceTests
{
    private readonly VehicleClientHistoryRepositoryMock _repositoryMock = new();

    private readonly List<VehicleClientHistoryEntity> _vehicleClientHistories = DataGenerator.AddVehicleClientHistoryData(5);

    public VehicleClientHistoryServiceTests()
    {
        _repositoryMock.GetRange(_vehicleClientHistories);
        _repositoryMock.GetById(_vehicleClientHistories[0]);
        _repositoryMock.IsExists(true);
    }

    [Fact]
    public async Task GetRangeAsync__ReturnsVehicleClientHistoryModelList()
    {
        //Arrange
        var correctModels = _vehicleClientHistories.Adapt<IEnumerable<VehicleClientHistoryModel>>();
        var service = new VehicleClientHistoryService(_repositoryMock.Object);

        //Act
        var response = await service.GetRangeAsync(1, 1, default);

        //Assert
        response.Should().BeEquivalentTo(correctModels);
    }

    [Fact]
    public async Task GetByIdAsync__ReturnsVehicleClientHistoryModel()
    {
        //Arrange
        var correctModel = _vehicleClientHistories[0].Adapt<VehicleClientHistoryModel>();
        var service = new VehicleClientHistoryService(_repositoryMock.Object);

        //Act
        var response = await service.GetByIdAsync(Guid.NewGuid(), default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task AddAsync_VehicleClientHistoryModel_ReturnsVehicleClientHistoryModel()
    {
        //Arrange
        var correctModel = _vehicleClientHistories[0].Adapt<VehicleClientHistoryModel>();
        var service = new VehicleClientHistoryService(_repositoryMock.Object);

        //Act
        var response = await service.AddAsync(correctModel, default);

        //Assert
        response.Should().BeEquivalentTo(correctModel);
    }

    [Fact]
    public async Task UpdateAsync_VehicleClientHistoryModel_ReturnsVehicleClientHistoryModel()
    {
        //Arrange
        var correctUpdatedModel = _vehicleClientHistories[1].Adapt<VehicleClientHistoryModel>();
        var service = new VehicleClientHistoryService(_repositoryMock.Object);

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

        var correctUpdatedModel = _vehicleClientHistories[1].Adapt<VehicleClientHistoryModel>();
        var service = new VehicleClientHistoryService(_repositoryMock.Object);

        //Act
        var response = async () => await service.UpdateAsync(correctUpdatedModel, default);

        //Assert
        await response.Should().ThrowAsync<NotFoundException>();
    }

    [Fact]
    public async Task DeleteAsync_VehicleClientHistoryId_()
    {
        //Arrange
        var service = new VehicleClientHistoryService(_repositoryMock.Object);

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

        var service = new VehicleClientHistoryService(_repositoryMock.Object);

        //Act
        var response = async () => await service.DeleteAsync(Guid.NewGuid(), default);

        //Assert
        await response.Should().ThrowAsync<NotFoundException>();
    }
}