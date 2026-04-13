using System;
using Core.Domain.Enums;

namespace Core.Application.DTOs;

public record CreateDeviceDto(string Name, string SerialNumber, string Mac, DeviceType Type, int LocationId, string Metadata);
