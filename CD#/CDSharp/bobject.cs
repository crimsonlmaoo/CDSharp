using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_.CDSharp
{
    public struct bobject
    {
        private readonly object value;

        public bobject(object value) => this.value = value;

        public object Value => value;

        public override string ToString() => value?.ToString() ?? "null";
    }
}
