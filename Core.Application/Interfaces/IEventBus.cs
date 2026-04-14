using System;

namespace Core.Application.Interfaces;

public interface IEventBus
{
  Task PublishAsync<T>(T @event, CancellationToken ct = default);
}
