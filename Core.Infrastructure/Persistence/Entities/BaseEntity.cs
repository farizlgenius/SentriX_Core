using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Infrastructure.Persistence.Entities;

public class BaseEntity
{
  [Key]
  public int id { get; set; }
  public DateTime created_at { get; set; } = DateTime.UtcNow;
  public DateTime updated_at { get; set; } = DateTime.UtcNow;
  public bool is_active { get; set; } = true;

  public BaseEntity() { }
  public BaseEntity(DateTime created, DateTime updated, bool active)
  {
    this.created_at = created;
    this.updated_at = updated;
    this.is_active = active;
  }
}
