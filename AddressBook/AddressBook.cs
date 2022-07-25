using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, ContactPersonInformation> addressBookMapper = new Dictionary<string, ContactPersonInformation>();
        public void AddAdressBook()
        {
            Console.WriteLine("\nEnter Name for the New Address Book");
            string name = Console.ReadLine();
            if (addressBookMapper.ContainsKey(name))
            {
                Console.WriteLine("Address Book Already exist with this name");
            }
            else
            {
                ContactPersonInformation contactPersonInformation = new ContactPersonInformation();
                addressBookMapper.Add(name, contactPersonInformation);
            }
        }

        public void AddContactsInAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to add new contact");
            string name = Console.ReadLine();
            if (!addressBookMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, ContactPersonInformation> tempPair in addressBookMapper)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                ContactPersonInformation contactPersonInformation = addressBookMapper[name];
                contactPersonInformation.AddingContactDetails();
                contactPersonInformation.DisplayContactDetails();
            }
        }

        public void EditDetailsOfAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to modify contact details");
            string name = Console.ReadLine();
            if (!addressBookMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, ContactPersonInformation> tempPair in addressBookMapper)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                ContactPersonInformation contactPersonInformation = addressBookMapper[name];
                contactPersonInformation.EditingContactDetails();
                contactPersonInformation.DisplayContactDetails();
            }
        }

        public void DeleteContactsOfAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to delete contact details");
            string name = Console.ReadLine();
            if (!addressBookMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, ContactPersonInformation> tempPair in addressBookMapper)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                ContactPersonInformation contactPersonInformation = addressBookMapper[name];
                contactPersonInformation.DeletingContactDetails();
                contactPersonInformation.DisplayContactDetails();
            }
        }
        public void DisplayingAddressBooks()
        {
            Console.WriteLine("***********************************************************");
            foreach (KeyValuePair<string, ContactPersonInformation> dictionaryPair in addressBookMapper)
            {
                Console.WriteLine("the name of address book is " + dictionaryPair.Key);
                ContactPersonInformation contactPersonInformation = dictionaryPair.Value;
                contactPersonInformation.DisplayContactDetails();
            }
        }
        public void DeletingAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to delete ");
            string name = Console.ReadLine();
            if (!addressBookMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, ContactPersonInformation> tempPair in addressBookMapper)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                addressBookMapper.Remove(name);
            }
        }
        public void SearchingByCity()
        {
            try
            {
                Console.WriteLine("Please enter the city");
                string searchCity = Console.ReadLine();
                //foreach loop to print name of address book and pass address book value to contact person information class
                foreach (KeyValuePair<string, ContactPersonInformation> keyValuePair in addressBookMapper)
                {
                    Console.WriteLine("Name of the address book: " + keyValuePair.Key);
                    ContactPersonInformation contactPersonInformation = keyValuePair.Value;
                    bool checkForException = contactPersonInformation.SearchingContactDetailsByCity(searchCity);
                }
            }
            //catches exception if city name does not exist
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Do you want to enter city again, press y for yes");
                string checkInput = Console.ReadLine();
                if (checkInput.ToLower() == "y")
                {
                    SearchingByCity();
                }
                else
                {
                    Console.WriteLine("No city entered");

                }
            }
        }
        /// <summary>
        /// Searching by state to get address book and contact details
        /// </summary>
        public void SearchingByState()
        {
            //used to find custom exception, if state do not exist
            try
            {
                Console.WriteLine("Please enter the state");
                string searchState = Console.ReadLine();
                //foreach loop is used to print key for dictionary and pass the values of dictionary to contact person information class
                foreach (KeyValuePair<string, ContactPersonInformation> keyValuePair in addressBookMapper)
                {
                    Console.WriteLine("Name of the address book: " + keyValuePair.Key);
                    ContactPersonInformation contactPersonInformation = keyValuePair.Value;
                    bool checkForException = contactPersonInformation.SearchingContactDetailsByState(searchState);
                }
            }
            catch (Exception ex)
            {
                //Exception message
                Console.WriteLine(ex.Message);
                Console.WriteLine("Do you want to enter state again, press y for yes");
                string checkInput = Console.ReadLine();
                if (checkInput.ToLower() == "y")
                {
                    //Details of state are entered again.
                    SearchingByState();
                }
                else
                {
                    Console.WriteLine("No state entered");

                }
            }
        }
    }
}
