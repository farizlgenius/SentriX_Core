using System;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Persistence;

public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
  public DbSet<Persistence.Entities.Device> Devices { get; set; }
  public DbSet<Persistence.Entities.CardFormat> CardFormats { get; set; }
  public DbSet<Persistence.Entities.Outbox> Outboxes { get; set; }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);


  }
}
