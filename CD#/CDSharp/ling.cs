using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_.CDSharp
{
    public struct ling
    {
        private readonly string value;

        public ling(string value) => this.value = value;
        public static implicit operator string(ling l) => l.value;
        public static implicit operator ling(string s) => new ling(s);

        public override string ToString() => value;
    }
}
