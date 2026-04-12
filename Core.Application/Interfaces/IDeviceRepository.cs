using System;
using Core.Application.DTOs;
using Core.Domain.Entities;

namespace Core.Application.Interfaces;

public interface IDeviceRepository : IBaseRepository<DeviceDto, Device>
{

}
