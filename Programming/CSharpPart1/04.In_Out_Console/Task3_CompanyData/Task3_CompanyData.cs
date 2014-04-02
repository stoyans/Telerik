using System;

namespace EnterDataforCompany
{
    class MainClass
    {
        public static void Main()
        {
            Console.Write("Enter Company Name: ");
            string companyname = Console.ReadLine();
            Console.Write("Enter Company Address: ");
            string companyaddress = Console.ReadLine();
            Console.Write("Enter Company Phone Number: ");
            string companyphone = Console.ReadLine();
            Console.Write("Enter Company WebAddress: ");
            string website = Console.ReadLine();
            Console.Write("Fill Company Manager's Name: ");
            string ManagerName = Console.ReadLine();
            Console.Write("Fill Company Manager's Phone: ");
            string ManagerPhone = Console.ReadLine();
            Console.WriteLine("The Company {0} is settled at {1}. You can contact them at number {2}.\nMore information you can find at {3}.\n" +
                          "Manger's name is mister {4} and his phone number is {5}.", companyname, companyaddress, companyphone, website, ManagerName, ManagerPhone);
        }
    }
}

