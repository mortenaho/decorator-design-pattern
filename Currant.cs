using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_design_pattern
{
    public class Currant : CondimentDecorator
    {
        Beverage bev;
        public Currant(Beverage beverage)
        {
            this.bev = beverage;
        }
        public   int Count()
        {
            return this.bev.Count()+250;
        }

        public  string Description()
        {
            return bev.Description()+ ", Currant";
        }
    }
}
