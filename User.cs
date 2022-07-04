using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdProject
{
    abstract class User
    {
        protected ElectricBill eBill;

        public abstract ElectricBill CreateBill();
    }
}
