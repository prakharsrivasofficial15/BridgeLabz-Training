using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMenu
    {
        private IAddressBook<ContactImpl, int> addressBook;

        public void Start()
        {
            addressBook = new AddressBookUtilityImpl();

            while (true)
            {
                Console.WriteLine("\n1. Create Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Add Contact");
                Console.WriteLine("4. Edit Contact");
                Console.WriteLine("5. Delete Contact");
                Console.WriteLine("6. Show Contacts");
                Console.WriteLine("7. Search Person by City");
                Console.WriteLine("8. Search Person by State");
                Console.WriteLine("9. Count Contacts by City");
                Console.WriteLine("10. Count Contacts by State");
                Console.WriteLine("11. Sort Contacts by Name");
                Console.WriteLine("12. Sort Contacts by City");
                Console.WriteLine("13. Sort Contacts by State");
                Console.WriteLine("14. Sort Contacts by Zip");
                Console.WriteLine("15. Save to File");
                Console.WriteLine("16. Load from File");
                Console.WriteLine("17. Save to CSV");
                Console.WriteLine("18. Load from CSV");
                Console.WriteLine("19. Save to JSON");
                Console.WriteLine("20. Load from Json");
                Console.WriteLine("21. Save to database");
                Console.WriteLine("22. Load from Database");
                Console.WriteLine("23. Update Contact in Database");
                Console.WriteLine("24. Delete Contact from Database");
                Console.WriteLine("0. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: addressBook.CreateAddressBook(); break;   
                    case 2: addressBook.SelectAddressBook(); break;   
                    case 3: addressBook.AddContact(); break;          
                    case 4: addressBook.EditContact(); break;         
                    case 5: addressBook.DeleteContact(); break;       
                    case 6: addressBook.ShowContacts(); break;       
                    case 7: addressBook.SearchByCity(); break;      
                    case 8: addressBook.SearchByState(); break;    
                    case 9: addressBook.CountByCity(); break;      
                    case 10: addressBook.CountByState(); break;     
                    case 11: addressBook.SortContactsByName(); break; 
                    case 12: addressBook.SortContactsByCity(); break;
                    case 13: addressBook.SortContactsByState(); break;
                    case 14: addressBook.SortContactsByZip(); break; 
                    case 15: addressBook.SaveToFile(); break;
                    case 16: addressBook.LoadFromFile(); break;
                    case 17: addressBook.SaveToCsv(); break;
                    case 18: addressBook.LoadFromCsv(); break;
                    case 19: addressBook.SaveToJson(); break;
                    case 20: addressBook.LoadFromJson(); break;
                    case 21: addressBook.SaveToDatabase(); break;
                    case 22: addressBook.LoadFromDatabase(); break;
                    case 23: addressBook.UpdateContactInDatabase(); break;
                    case 24: addressBook.DeleteContactFromDatabase(); break;
                    case 0: return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}


//done