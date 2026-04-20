using System;
using Core.Domain.Entities;

namespace Core.Application.Interfaces;

public interface IEventPublisher
{
  Task PublishAsync(Event @event, CancellationToken ct = default);
  Task PublishRealTimeAsync(string message,CancellationToken ct = default);
}
