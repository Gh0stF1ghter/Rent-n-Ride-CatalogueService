﻿using Mapster;
using System.Reflection;

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