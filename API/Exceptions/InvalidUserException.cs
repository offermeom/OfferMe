using System.Runtime.Serialization;
namespace API.Exceptions;
public class InvalidUserException : Exception
{
    public InvalidUserException() { }
    public InvalidUserException(string message) : base(message) { }
    public InvalidUserException(string message, Exception inner) : base(message, inner) { }
    protected InvalidUserException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}