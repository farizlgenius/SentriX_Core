using System;

namespace Core.Api.Exceptions;

public class NotFoundException : Exception
{
  public NotFoundException() { }
  public NotFoundException(string Message) : base(Message) { }
  public NotFoundException(string Message, Exception InnerException) : base(Message, InnerException) { }
}
