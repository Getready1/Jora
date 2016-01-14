using System;

namespace SocialNetwork.Logging
{
    public interface ILogger
    {
        void Write(string message, EventSeverity severity);
        void Write(string message, Exception exception, EventSeverity severity);
    }
}
