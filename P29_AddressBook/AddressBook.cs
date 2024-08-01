using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P29_AddressBook
{
    public class AddressBook : Contact
    {
        private const string FilePath = "C:\\Users\\raimo\\Source\\Repos\\CodeAcademySecondPart\\P29_AddressBook\\contacts.csv";

        
        protected void AddContact()
        {
            Console.WriteLine("Enter first name (or type 'q' to go back): ");
            string firstName = Console.ReadLine();
            if (firstName.ToLower() == "q") return;

            Console.WriteLine("Enter last name (or type 'q' to go back): ");
            string lastName = Console.ReadLine();
            if (lastName.ToLower() == "q") return;

            Console.WriteLine("Enter phone number (or type 'q' to go back): ");
            string phoneNumber = Console.ReadLine();
            if (phoneNumber.ToLower() == "q") return;

            Console.WriteLine("Enter email (or type 'q' to go back): ");
            string email = Console.ReadLine();
            if (email.ToLower() == "q") return;

            var newContact = new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Email = email
            };

            string contactString = $"{newContact.FirstName},{newContact.LastName},{newContact.PhoneNumber},{newContact.Email}{Environment.NewLine}";
            File.AppendAllText(FilePath, contactString);
        }

        protected void ViewContacts()
        {
            if (File.Exists(FilePath))
            {
                string[] contacts = File.ReadAllLines(FilePath);
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact.Replace(",", " "));
                }
            }
        }

        protected void DeleteContact()
        {
            if (!File.Exists(FilePath)) return;

            Console.WriteLine("Enter the name of the contact you want to delete: ");
            string contactToDelete = Console.ReadLine();
            var contacts = File.ReadAllLines(FilePath).ToList();
            bool found = false;

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].StartsWith(contactToDelete + ","))
                {
                    contacts.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (found)
            {
                File.WriteAllLines(FilePath, contacts);
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        protected void SearchContact()
        {
            if (!File.Exists(FilePath)) return;

            Console.WriteLine("Enter the name of the contact you want to search for: ");
            string contactToSearch = Console.ReadLine();
            var contacts = File.ReadAllLines(FilePath);

            foreach (var contact in contacts)
            {
                if (contact.StartsWith(contactToSearch + ","))
                {
                    Console.WriteLine(contact.Replace(",", " "));
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }
    }
}
