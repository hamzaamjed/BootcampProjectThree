using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampProjectThree
{
    class Commercial : User
    {

        public override ElectricBill CreateBill()
        {
            eBill = new ElectricBill("commercial");
            return eBill;
        }
    }
}
