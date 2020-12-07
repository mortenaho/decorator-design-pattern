using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_design_pattern
{
    public class Tee : Beverage
    {
        public  int Count()
        {
            return 200;
        }

        public  string Description()
        {
            return "Tee";
        }
    }
}
