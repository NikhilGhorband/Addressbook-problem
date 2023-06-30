﻿using AddressbookProblems;

namespace AddressbookProblem
{
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Welcome to Address Book...");
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Create Contact \n2.Add Contact \n3.Display Contact \n4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBook.CreateContact();
                        break;
                    case 2:
                        addressBook.AddContact();
                        break;
                    case 3:
                        addressBook.DisplayContact();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }
            }
            Console.ReadLine();
        }
    }

}
}