using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_.CDSharp
{
    public readonly struct yool
    {
        private readonly bool val;

        private yool(bool value) => val = value;

        public static readonly yool yes = new yool(true);
        public static readonly yool no = new yool(false);
        public static implicit operator bool(yool y) => y.val;
        public static yool operator !(yool y) => y.val ? no : yes;
        public static yool operator &(yool a, yool b) => (a.val && b.val) ? yes : no;
        public static yool operator |(yool a, yool b) => (a.val || b.val) ? yes : no;

        public override string ToString() => val ? "yes" : "no";
        public static implicit operator yool(yes_type _) => yes;
        public static implicit operator yool(no_type _) => no;
    }
}
