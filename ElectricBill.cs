using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampProjectThree
{
    class ElectricBill
    {
        private string userType;
        
        public ElectricBill(string userType)
        {
            this.userType = userType;
        }

        public int CalculateResidentialBill()
        {

            return 0;
        }

        public double CalculateBill(int unitConsumed)
        {
            double totalBill = 0;
            double tax = 0;
            if (userType.Equals(userType))
            {
                if(unitConsumed > 1 & unitConsumed <= 100)
                {
                    totalBill = unitConsumed * 5;
                }
                else if (unitConsumed >100 & unitConsumed <= 200) 
                {
                    totalBill = unitConsumed * 17;
                }
                else if (unitConsumed > 200 & unitConsumed <= 500)
                {
                    totalBill = unitConsumed * 23;
                }
                else if (unitConsumed > 500)
                {
                    totalBill = unitConsumed * 69;
                }

                tax = (totalBill * 13) / 100;
                totalBill += tax;

            }
            else if (userType.Equals(userType))
            {
                if (unitConsumed > 1 & unitConsumed <= 100)
                {
                    totalBill = unitConsumed * 8;
                }
                else if (unitConsumed > 100 & unitConsumed <= 200)
                {
                    totalBill = unitConsumed * 21;
                }
                else if (unitConsumed > 200 & unitConsumed <= 500)
                {
                    totalBill = unitConsumed * 23;
                }
                else if (unitConsumed > 500)
                {
                    totalBill = unitConsumed * 79;
                }

                tax = (totalBill * 17) / 100;
                totalBill += tax;

            }

            return totalBill;
        }
    }
}
