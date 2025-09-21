using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_.CDSharp
{
    public struct lint
    {
        private readonly int value;

        public lint(int value) => this.value = value;

        public static implicit operator int(lint l) => l.value;
        public static implicit operator lint(int i) => new lint(i);
        public static lint operator +(lint a, lint b) => new lint(a.value + b.value);
        public static lint operator -(lint a, lint b) => new lint(a.value - b.value);
        public static lint operator *(lint a, lint b) => new lint(a.value * b.value);
        public static lint operator /(lint a, lint b) => new lint(a.value / b.value);

        public override string ToString() => value.ToString();
    }
}
