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
    builder.Services.AddScoped<ICardFormatRepository, CardFormatRepository>();


    // ==========================
    // Adding Service
    // ==========================
    builder.Services.AddScoped<IDeviceService, DeviceService>();
    builder.Services.AddScoped<ICardFormatService, CardFormatService>();


    // ==========================
    // Custom Service
    // ==========================
    builder.Services.AddTransient<GlobalExceptionMiddleware>();



  }

}
