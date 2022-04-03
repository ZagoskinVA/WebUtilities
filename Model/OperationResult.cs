using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUtilities.Model
{
    public enum OperationStatus
    {
        Success,
        Failed
    }
    public class OperationResult
    {
        public OperationStatus Status { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
    }
}
