using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookException
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
     class AddressBook
    {
        private const int MaxContacts = 10;
        private Contact[] contacts;
        public int contactCount;

        public AddressBook()
        {
            contacts = new Contact[MaxContacts];
            contactCount = 0;
        }

        public void AddContact(Contact contact)
        {

             if (contactCount < MaxContacts)
            {
                contacts[contactCount] = contact;
                contactCount++;
            }
            else
            {
                Console.WriteLine("Address book is full. Cannot add more contacts.");
            }
        }

         public void EditContact()
             {
            Console.WriteLine("Enter the name of the contact to edit:");
            string editName = Console.ReadLine();


            bool isFound = false;
            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName.Equals(editName, StringComparison.OrdinalIgnoreCase))
                {
                   
                    Console.WriteLine("Enter LastName:");
                    contacts[i].LastName = Console.ReadLine();
                    Console.WriteLine("Enter ContactNumber:");
                    contacts[i].ContactNumber = Console.ReadLine();
                    Console.WriteLine("Enter Email:");
                    contacts[i].Email = Console.ReadLine();
                    Console.WriteLine("Enter City:");
                    contacts[i].City = Console.ReadLine();
                    Console.WriteLine("Enter State:");
                    contacts[i].State = Console.ReadLine();
                    Console.WriteLine("Enter Zip Code:");
                    contacts[i].ZipCode = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully!");
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Contact not found");
            }
        }
        public void DeleteContact(string contactName)
        {
            int index = -1;

            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName.Equals(contactName, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < contactCount - 1; i++)
                {
                    contacts[i] = contacts[i + 1];
                }
                contactCount--;

                Console.WriteLine("Contact deleted successfully.");
            }

            else
            {
                Console.WriteLine("Contact not found.");
            }

        }

        public void PrintContacts()
        {
            if (contactCount != 0) {
                for (int i = 0; i < contactCount; i++)
                {
                    Console.WriteLine($"Contact {i + 1}:");
                    Console.WriteLine($"FirstName: {contacts[i].FirstName}");
                    Console.WriteLine($"LastName: {contacts[i].LastName}");
                    Console.WriteLine($"ContactNumber: {contacts[i].ContactNumber}");
                    Console.WriteLine($"Email: {contacts[i].Email}");
                    Console.WriteLine($"City: {contacts[i].City}");
                    Console.WriteLine($"State: {contacts[i].State}");
                    Console.WriteLine($"ZipCode: {contacts[i].ZipCode}");

                    Console.WriteLine();

                }

            }
            else
            {
                Console.WriteLine("No contacts in address book");
            }
        }

    }
}
