using System;
using Core.Application.DTOs;
using Core.Application.Interfaces;

namespace Core.Application.Services;

public class DeviceService : IDeviceService
{
  public async Task<DeviceDto> CreateAsync(CreateDeviceDto dto)
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

  public async Task<DeviceDto> UpdateAsync(UpdateDeviceDto dto)
  {
    throw new NotImplementedException();
  }
}
