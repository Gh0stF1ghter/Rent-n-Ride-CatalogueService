using BLL.ViewModels;
using DAL.Entities;
using Mapster;

namespace BLL.MappingConfigurations;

internal class ClientMapperConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config
            .NewConfig<Client, ClientViewModel>()
            .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}");
    }
}
