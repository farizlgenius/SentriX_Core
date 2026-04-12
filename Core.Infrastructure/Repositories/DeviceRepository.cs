using System;
using Core.Application.DTOs;
using Core.Application.Interfaces;
using Core.Domain.Entities;
using Core.Infrastructure.Persistence;

namespace Core.Infrastructure.Repositories;

public sealed class DeviceRepository(AppDbContext context) : IDeviceRepository
{
  public async Task<DeviceDto> CreateAsync(Device domain)
  {
    throw new NotImplementedException();
  }

  public async Task<DeviceDto> DeleteByIdAsync(int id)
  {
    throw new NotImplementedException();
  }

  public async Task<PaginationDto<DeviceDto>> GetPaginationByLocationIdAsync(int location, int Page, int PageSize)
  {
    throw new NotImplementedException();
  }

  public async Task<DeviceDto> UpdateAsync(Device domain)
  {
    throw new NotImplementedException();
  }
}
