using System;

namespace Core.Api.Exceptions;

public sealed class BadRequestException : Exception
{
  public BadRequestException() { }
  public BadRequestException(string Message) : base(Message) { }
  public BadRequestException(string Message, Exception InnerException) : base(Message, InnerException) { }
}
