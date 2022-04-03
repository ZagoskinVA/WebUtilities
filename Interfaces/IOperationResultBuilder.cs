using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUtilities.Model;

namespace WebUtilities.Interfaces
{
    public interface IOperationResultBuilder<T> where T : OperationResult
    {
        IOperationResultBuilder<T> SetSuccessStatus();
        IOperationResultBuilder<T> SetFailureStatus();
        IOperationResultBuilder<T> AddMessage(string message);
        IOperationResultBuilder<T> AddMessages(IEnumerable<string> messages);
        T Build();
    }
}
