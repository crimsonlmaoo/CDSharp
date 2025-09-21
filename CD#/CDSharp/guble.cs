using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_.CDSharp
{
    public struct guble
    {
        private readonly double value;

        public guble(double value) => this.value = value;

        public static implicit operator double(guble g) => g.value;
        public static implicit operator guble(double d) => new guble(d);

        public static guble operator +(guble a, guble b) => new guble(a.value + b.value);
        public static guble operator -(guble a, guble b) => new guble(a.value - b.value);
        public static guble operator *(guble a, guble b) => new guble(a.value * b.value);
        public static guble operator /(guble a, guble b) => new guble(a.value / b.value);

        public override string ToString() => value.ToString();
    }
}
