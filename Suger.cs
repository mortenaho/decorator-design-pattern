using System;
using System.Collections.Generic;
using System.Text;

namespace decorator_design_pattern
{
    public class Suger : CondimentDecorator
    {
        Beverage bev;
        public Suger(Beverage beverage)
        {
            this.bev = beverage;
        }
        public  int Count()
        {
            return this.bev.Count()+150;
        }

        public   string Description()
        {
            return bev.Description()+", Sugar";
        }
    }
}
