using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdProject
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
