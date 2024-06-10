using API.ViewModels;
using DAL.Entities;
using Mapster;

namespace API.MappingConfigurations;

internal class ClientMapperConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config
            .NewConfig<Client, ClientViewModel>()
            .MaxDepth(2)
            .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}");
    }
}
