using System;
using Core.Domain.Enums;

namespace Core.Infrastructure.Persistence.Entities;

public sealed class Device : BaseEntity
{
  public string name { get; set; } = string.Empty;
  public string serial_number { get; set; } = string.Empty;
  public string mac { get; set; } = string.Empty;
  public DeviceType type { get; set; } = DeviceType.UNKNOWN;
  public string metadata { get; set; } = string.Empty;

  // Relation
  public int location_id { get; set; }

  public Device() { }

  public Device(Domain.Entities.Device domain)
  {
    this.name = domain.Name;
    this.serial_number = domain.SerialNumber;
    this.mac = domain.Mac;
    this.metadata = domain.Metadata;
    this.type = domain.Type;
    this.location_id = domain.LocationId;
    this.updated_at = DateTime.UtcNow;
    this.created_at = DateTime.UtcNow;
  }

  public void Update(Domain.Entities.Device domain)
  {
    this.name = domain.Name;
    this.serial_number = domain.SerialNumber;
    this.mac = domain.Mac;
    this.metadata = domain.Metadata;
    this.type = domain.Type;
    this.location_id = domain.LocationId;
    this.updated_at = DateTime.UtcNow;
  }


}
