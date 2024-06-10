using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MappingConfigurations;
public static class GlobalMappingSettings
{
    public static void SetMapper()
    {
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        TypeAdapterConfig.GlobalSettings.Default.MaxDepth(3);
        TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
    }
}
