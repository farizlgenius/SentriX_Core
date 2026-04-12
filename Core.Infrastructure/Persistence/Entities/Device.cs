using System;

namespace Core.Infrastructure.Persistence.Entities;

public sealed class Device : BaseEntity
{
  public string name { get; set; } = string.Empty;
  public string serial_number { get; set; } = string.Empty;
  public string mac { get; set; } = string.Empty;

  public Device() { }



}
