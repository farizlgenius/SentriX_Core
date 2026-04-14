using System;
using System.Text.Json;
using Core.Application.Interfaces;
using Core.Infrastructure.Messaging;
using RabbitMQ.Client;

namespace Core.Infrastructure.Publisher;

public sealed class RabbitMqEventBus : IEventBus
{
  private readonly IRabbitMqFactory _connection;
  private readonly IRabbitMqOptions _options;
  public RabbitMqEventBus(IRabbitMqFactory connection, IRabbitMqOptions options)
  {
    _connection = connection;
    _options = options;
  }
  public async Task PublishAsync<T>(T @event, CancellationToken ct = default)
  {
    var connection = await _connection.GetConnectionAsync(ct);
    var channel = await connection.CreateChannelAsync(cancellationToken: ct);

    // Declare Exchage 
    await channel.ExchangeDeclareAsync(
      "device-command-exchange",
      ExchangeType.Topic,
      durable: true,
      cancellationToken: ct
    );

    var body = JsonSerializer.SerializeToUtf8Bytes(@event);

    await channel.BasicPublishAsync(
      exchange: "",
      routingKey: typeof(T).Name,
      mandatory: true,
      basicProperties: new BasicProperties
      {
        DeliveryMode = DeliveryModes.Persistent
      },
      body: body,
      cancellationToken: ct
    );
  }
}
