using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_design_pattern
{
    public interface CondimentDecorator : Beverage
    {
        public int Count();
        public string Description();
    }
}
