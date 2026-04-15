using System;
using Core.Domain.Enums;
using Core.Domain.Helpers;

namespace Core.Domain.Entities;

public sealed class Device
{
  public int Id { get; private set; }
  public string Name { get; private set; } = string.Empty;
  public string SerialNumber { get; private set; } = string.Empty;
  public string Mac { get; private set; } = string.Empty;
  public DeviceType Type { get; private set; } = DeviceType.aero;
  public int LocationId { get; private set; }
  public string Metadata { get; private set; } = string.Empty;

  public Device(int id, string name, string serialnumber, string mac, DeviceType type, int locationid, string metadta)
  {
    ValidationHelper.ValidateNotMinus(id, nameof(Id));
    ValidationHelper.ValidateNotNullOrEmpty(name, nameof(Name));
    ValidationHelper.ValidateNotNullOrEmpty(serialnumber, nameof(SerialNumber));
    ValidationHelper.ValidateNotNullOrEmpty(mac, nameof(Mac));
    ValidationHelper.ValidateNotMinus(locationid, nameof(LocationId));
    this.Id = id;
    this.Name = name;
    this.SerialNumber = serialnumber;
    this.Mac = mac;
    this.Type = type;
    this.LocationId = locationid;
    this.Metadata = metadta;
  }
}
