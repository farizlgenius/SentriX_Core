using System;
using System.Text.Json;
using Core.Application.Interfaces;
using Core.Domain.Entities;
using Core.Infrastructure.Messaging;
using RabbitMQ.Client;

namespace Core.Infrastructure.Publisher;

public sealed class RabbitMqEventPublisher : IEventPublisher
{
  private readonly IRabbitMqFactory _connection;
  public RabbitMqEventPublisher(IRabbitMqFactory connection, IRabbitMqOptions options)
  {
    _connection = connection;
  }
  public async Task PublishAsync(Event @event, CancellationToken ct = default)
  {
    var connection = await _connection.GetConnectionAsync(ct);
    var channel = await connection.CreateChannelAsync(cancellationToken: ct);

    // Declare Exchage 
    await channel.ExchangeDeclareAsync(
      "sentrix-exchange",
      ExchangeType.Topic,
      durable: true,
      cancellationToken: ct
    );

    var routingKey = $"{@event.ModuleType}.{@event.DeviceType}.{@event.EventType}";
    Console.WriteLine(routingKey);

    var body = JsonSerializer.SerializeToUtf8Bytes(@event);

    await channel.BasicPublishAsync(
      exchange: "sentrix-exchange",
      routingKey: routingKey,
      body: body,
      cancellationToken: ct
    );
  }
}
