using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralizedExceptionHandlingWithSerilogLogging.Model
{
    internal class ErrorResponse
    {
        public string Error { get; set; }
        public string? Details { get; set; }
        public string? TraceId { get; set; }
    }
}
