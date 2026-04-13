using System;
using Core.Domain.Enums;

namespace Core.Application.DTOs;

public record DeviceDto(int Id, string Name, string SerialNumber, string Mac, string Type, int LocationId, object Metadata);
