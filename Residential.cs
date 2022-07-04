using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampProjectThree
{
    class Residential : User
    {
        public override ElectricBill CreateBill()
        {
            eBill = new ElectricBill("residential");
            return eBill;
        }
    }
}
