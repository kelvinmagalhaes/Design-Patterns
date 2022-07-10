using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento.Utils
{
    public class Invest
    {
        public double Value { get; private set; }

        public Invest(double value)
        {
            this.Value = value;
        }
    }
}
