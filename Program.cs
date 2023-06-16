using System.Linq.Expressions;
namespace AddressBookException
{

    public class InvalidInput : Exception
    {
        public InvalidInput() { }
        public InvalidInput(string message) : base(message)
        {

        }
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Address Book Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Print Contacts");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice:");
                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    if (choice > 5)
                    {
                        throw new InvalidInput();

                    }



                    switch (choice)
                    {


                        case 1:
                            Console.WriteLine("Enter First Name:");
                            string FirstName = Console.ReadLine();
                            Console.WriteLine("Enter LastName:");
                            string LastName = Console.ReadLine();
                            Console.WriteLine("Enter Contact Number:");
                            string ContactNumber = Console.ReadLine();
                            Console.WriteLine("Enter Email ID:");
                            string Email = Console.ReadLine();
                            Console.WriteLine("Enter Your city:");
                            string City = Console.ReadLine();
                            Console.WriteLine("Enter Your state :");
                            string State = Console.ReadLine();
                            Console.WriteLine("Enter Your Zip code:");
                            string ZipCode = Console.ReadLine();


                            Contact contact = new Contact
                            {
                                FirstName = FirstName,
                                LastName = LastName,
                                ContactNumber = ContactNumber,
                                Email = Email,
                                City = City,
                                State = State,
                                ZipCode = ZipCode

                            };

                            addressBook.AddContact(contact);
                            Console.WriteLine("Contact added successfully.");
                            Console.WriteLine();
                            break;

                        

                        case 2: 
                            addressBook.EditContact(); 
                        break;
                            
                        case 3:
                            Console.WriteLine("enter the first name to delete the contact");
                            string deleteFirstName = Console.ReadLine();
                            addressBook.DeleteContact(deleteFirstName);
                            break;

                        case 4:
                            addressBook.PrintContacts();
                            Console.WriteLine();
                            break;

                        case 5:
                            return;


                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            Console.WriteLine();
                            break;
                    }

                }

                //custom exception

                catch (InvalidInput)
                {
                    Console.WriteLine("custom exception :  Invalid input please enter the valid input from the MENU[1-5]");
                }

                //system exception 
                catch (FormatException ex)
                {
                    Console.WriteLine("PLEASE ENTER ONLY NUMBERES");
                }
            }

        }
    }
}