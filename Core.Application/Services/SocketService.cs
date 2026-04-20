using System;
using Core.Application.Interfaces;

namespace Core.Application.Services;

public class SocketService(IEventPublisher publisher) : ISockerService
{
      public async Task<bool> TestSocketAsync(string message)
      {
            await publisher.PublishRealTimeAsync(message);
            return true;
      }
}
