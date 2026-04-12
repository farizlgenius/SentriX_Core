using System;

namespace Core.Application.DTOs;

public record DeviceDto(int Id, string Name, string SerialNumner, string Mac);
