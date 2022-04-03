using WebUtilities.Interfaces;
using WebUtilities.Model;

namespace WebUtilities.Services
{
    public class OperationResultBuilder<T> : IOperationResultBuilder<T> where T : OperationResult, new()
    {
        private T operationResult = new();
        public Interfaces.IOperationResultBuilder<T> AddMessage(string message)
        {
            operationResult.Messages.Add(message);
            return this;
        }

        public Interfaces.IOperationResultBuilder<T> AddMessages(IEnumerable<string> messages)
        {
            operationResult.Messages.AddRange(messages);
            return this;
        }

        public T Build()
        {
            return operationResult;
        }

        public Interfaces.IOperationResultBuilder<T> SetFailureStatus()
        {
            operationResult.Status = OperationStatus.Failed;
            return this;

        }

        public Interfaces.IOperationResultBuilder<T> SetSuccessStatus()
        {
            operationResult.Status = OperationStatus.Success;
            return this;
        }
    }
}
