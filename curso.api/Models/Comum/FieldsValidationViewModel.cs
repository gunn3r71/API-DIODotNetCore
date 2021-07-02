using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Comum
{
    public class FieldsValidationViewModel
    {
        public FieldsValidationViewModel(IEnumerable fields)
        {
            this.Fields = fields;
        }
        public IEnumerable Fields { get; private set; }
    }
}
