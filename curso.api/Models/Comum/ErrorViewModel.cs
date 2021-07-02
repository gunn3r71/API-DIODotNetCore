using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Comum
{
    public class ErrorViewModel
    {
        public ErrorViewModel(string message)
        {
            this.Message = message;
        }
        public string Message { get; private set; }
    }
}
