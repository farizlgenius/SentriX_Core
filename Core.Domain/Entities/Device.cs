using System;

namespace Core.Domain.Entities;

public sealed class Device
{
  public int Id { get; private set; }
  public string Name { get; private set; } = string.Empty;
  public string SerialNumber { get; private set; } = string.Empty;
  public string Mac { get; private set; } = string.Empty;
}
