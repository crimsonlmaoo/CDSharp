using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_.CDSharp
{
    public struct yes_type { }
    public struct no_type { }
    public static class YesNo
    {
        public static readonly yes_type yes = new yes_type();
        public static readonly no_type no = new no_type();
    }
}
