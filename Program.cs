using System;

namespace BootcampProjectThree
{
    class Program
    {
        static void Main(string[] args)
        {

            ElectricBill eBill;
            double totalBill;
            int chooseUserType;
            int unitConsumed;
            Console.WriteLine(" ***** Electric Bill *****");
            Console.WriteLine("\n Electricity User Types : ");
            Console.WriteLine(" 1. Residential \n 2. Commercial ");
            Console.Write("\n Choose Your User Type For Electric Bill: ");
            chooseUserType = Convert.ToInt32(Console.ReadLine());

            Console.Write("PLease Enter The Unit Consumed: ");
            unitConsumed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (chooseUserType)
            {
                case 1:

                    User resUser = new Residential();
                    eBill = resUser.CreateBill();
                    totalBill = eBill.CalculateBill(unitConsumed);
                    Console.WriteLine("Total Bill: " + totalBill + " Rs.");

                    break;
                case 2:

                    User comUser = new Commercial();
                    eBill = comUser.CreateBill();
                    totalBill = eBill.CalculateBill(unitConsumed);
                    Console.WriteLine("Total Bill: " + totalBill + " Rs.");

                    break;

                default:
                    break;
            }
        }
    }
}
