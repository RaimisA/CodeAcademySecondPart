using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P29_AddressBook
{
    public class ProgramUI : AddressBook
    {
        internal void ShowMenu()
        {
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. View contacts");
            Console.WriteLine("3. Delete contact");
            Console.WriteLine("4. Search contact");
            Console.WriteLine("5. Exit");
        }
        internal void HandleUserChoice()
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                ShowMenu();
                string? userChoice = Console.ReadLine();
                if (userChoice == null) continue;
                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        AddContact();
                        break;
                    case "2":
                        Console.Clear();
                        ViewContacts();
                        break;
                    case "3":
                        Console.Clear();
                        DeleteContact();
                        break;
                    case "4":
                        Console.Clear();
                        SearchContact();
                        break;
                    case "5":
                        continueRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        
    }
}
