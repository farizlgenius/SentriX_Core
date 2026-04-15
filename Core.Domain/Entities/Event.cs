using System;
using Core.Domain.Enums;

namespace Core.Domain.Entities;

public sealed class Event
{
  public ModuleType ModuleType { get; set; }
  public DeviceType DeviceType { get; set; }
  public EventType EventType { get; set; }
  public object Metadata { get; set; } = default!;
  public Event(ModuleType module, DeviceType device, EventType even, object metadata)
  {
    this.ModuleType = module;
    this.DeviceType = device;
    this.EventType = even;
    this.Metadata = metadata;
  }
}
