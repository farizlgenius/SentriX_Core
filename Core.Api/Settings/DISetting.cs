using System;
using Core.Api.Middlewares;
using Core.Application.Interfaces;
using Core.Application.Services;
using Core.Infrastructure.Repositories;

namespace Core.Api.Settings;

public class DISetting
{
  public static void DependencyInjectionSetting(WebApplicationBuilder builder)
  {
    // ==========================
    // Adding Repository
    // ==========================
    builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();


    // ==========================
    // Adding Service
    // ==========================
    builder.Services.AddScoped<IDeviceService, DeviceService>();


    // ==========================
    // Custom Service
    // ==========================
    builder.Services.AddTransient<GlobalExceptionMiddleware>();



  }

}
