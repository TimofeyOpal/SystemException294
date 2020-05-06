using System;
using System.Collections.Generic;
using System.Text;

namespace SystemException294
{
    class CarlsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public CarlsDeadException() { }
        public CarlsDeadException(string message,
        string cause, DateTime time)
        {
            messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
        // Переопределить свойство Exception.Message .
        public override string Message => $"Car Error Message: {messageDetails}";

    }
    }
