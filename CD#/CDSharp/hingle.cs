using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_.CDSharp
{
    public struct hingle
    {
        private readonly float value;

        public hingle(float value) => this.value = value;

        public static implicit operator float(hingle h) => h.value;
        public static implicit operator hingle(float f) => new hingle(f);

        public static hingle operator +(hingle a, hingle b) => new hingle(a.value + b.value);
        public static hingle operator -(hingle a, hingle b) => new hingle(a.value - b.value);
        public static hingle operator *(hingle a, hingle b) => new hingle(a.value * b.value);
        public static hingle operator /(hingle a, hingle b) => new hingle(a.value / b.value);

        public override string ToString() => value.ToString();
    }
}
