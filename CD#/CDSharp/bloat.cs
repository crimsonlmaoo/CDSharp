using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_.CDSharp
{
    public struct bloat
    {
        private readonly float value;

        public bloat(float value) => this.value = value;

        public static implicit operator float(bloat b) => b.value;
        public static implicit operator bloat(float f) => new bloat(f);

        public static bloat operator +(bloat a, bloat b) => new bloat(a.value + b.value);
        public static bloat operator -(bloat a, bloat b) => new bloat(a.value - b.value);
        public static bloat operator *(bloat a, bloat b) => new bloat(a.value * b.value);
        public static bloat operator /(bloat a, bloat b) => new bloat(a.value / b.value);

        public override string ToString() => value.ToString();
    }
}
