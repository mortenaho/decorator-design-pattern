using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_design_pattern
{
    public class Cafe : Beverage
    {
        public  int Count()
        {
            return 400;
        }

        public  string Description()
        {
            return "Cafe";
        }
    }
}
