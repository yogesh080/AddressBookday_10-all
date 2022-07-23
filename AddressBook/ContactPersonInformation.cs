﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class ContactPersonInformation
    {
        List<ContactDetails> contactDetailsList;
        private readonly NLog nLog = new NLog();


        public ContactPersonInformation()
        {
            contactDetailsList = new List<ContactDetails>();
        }

        public void AddingContactDetails()
        {
            ContactPersonInformation contactPersonalInformation = new ContactPersonInformation();
            //able to add multiple contact details in one list

            while (true)
            {
Repeat: Console.WriteLine("Please enter first name, last name, address, city, state, zip, phoneno and email");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    nLog.LogInfo("No more contact details have been entered");
                    break;
                }
                string lastName = Console.ReadLine();
                string address = Console.ReadLine();
                string city = Console.ReadLine();
                string state = Console.ReadLine();
                int zip = Convert.ToInt32(Console.ReadLine());
                double phoneNo = Convert.ToDouble(Console.ReadLine());
                if (phoneNo <= 200000)
                {
                    //Console.WriteLine("Please enter a valid Phone no.");
                    nLog.LogError("Entered Wrong Phone no. : AdditionContactDetails()");
                    Console.WriteLine("Wrong phone details entered, please enter your details again");
                    goto Repeat;
                }
                string eMail = Console.ReadLine();

                ContactDetails contactDetails = new ContactDetails(firstName, lastName, address, city, state, zip, phoneNo, eMail);

                //if (contactDetailsList.Contains(contactDetails))----------> ask doubt.
                foreach (ContactDetails contactDetail in contactDetailsList)
                {
                    if (contactDetail.firstName == firstName && contactDetail.lastName == lastName && contactDetail.address == address && contactDetail.city == city && contactDetail.state == state && contactDetail.zip == zip && contactDetail.phoneNo == phoneNo && contactDetail.eMail == eMail)
                    {
                        nLog.LogError("Contact details have already been entered");
                        Console.WriteLine("Contact details have already been entered\n please add new contact details");
                        goto Repeat;
                    }

                }
                //else
                //{
                contactDetailsList.Add(contactDetails);
                nLog.LogDebug("Contact Details Addition Successful: AddingContactDetails()");
                //}
            }

            contactPersonalInformation.DisplayContactDetails();
            AddressBook addressBook = new AddressBook();
            //addressBook.AddingAddressBook(contactDetailsList);


        }
        public void DisplayContactDetails()
        {
            foreach (ContactDetails contactPerson in contactDetailsList)
            {
                Console.WriteLine($"First Name : {contactPerson.firstName} || Last Name: {contactPerson.lastName} || Address: {contactPerson.address} || City: {contactPerson.city} || State: {contactPerson.state}|| zip: {contactPerson.zip} || Phone No: {contactPerson.phoneNo} || eMail: {contactPerson.eMail}");
            }
            nLog.LogDebug("Displaying Contact Details Successful :DisplayingContactDetails()");
        }
        public void EditingContactDetails()
        {
            ContactPersonInformation contact = new ContactPersonInformation();
addingDetailsAgainForEditing: Console.WriteLine("Please help us, first identify you");
            Console.WriteLine("Please enter your first name and phone no");
            string firstNm = Console.ReadLine();
            int editCheck = 0;
            double mobileNo = Convert.ToDouble(Console.ReadLine());
            foreach (ContactDetails contactDetails in contactDetailsList)
            {
                if (contactDetails.firstName == firstNm && contactDetails.phoneNo == mobileNo)
                {
EditAgain: Console.WriteLine("please select the serial no. of field which you want to change\n 1. First name \n2.Last name\n3.Address\n4.City\n5.State\n6.Zip code\n7.Phone no.\n 8.email");
                    int inputForEditing = Convert.ToInt32(Console.ReadLine());
                    editCheck++;
                    switch (inputForEditing)
                    {
                        case 1:
firstname: Console.WriteLine("please enter the first name");
                            string newFirstName = Console.ReadLine();
                            if (contactDetails.firstName == newFirstName)
                            {
                                Console.WriteLine("You entered same user name");
                                Console.WriteLine("Please enter details again");
                                goto firstname;
                            }
                            contactDetails.firstName = newFirstName;
                            nLog.LogDebug("Debug successful, firstname successfully changed : EditingContactDetails()");
                            Console.WriteLine("Do you want to update anything else, press y to update again,else press enter");
                            string inputAfterFirstName = Console.ReadLine();
                            if (inputAfterFirstName.ToLower() == "y")
                            {
                                nLog.LogInfo("User wants to update further information");
                                goto EditAgain;
                            }
                            else
                            {
                                nLog.LogInfo("Updation Process Completed : EditinContactDetails()");
                                break;
                            }
                        case 2:
lastname: Console.WriteLine("please enter the last name");
                            string newlastName = Console.ReadLine();
                            if (contactDetails.lastName == newlastName)
                            {
                                Console.WriteLine("You entered same user name");
                                Console.WriteLine("Please enter details again");
                                goto lastname;
                            }
                            contactDetails.lastName = newlastName;
                            nLog.LogDebug("Debug successful, lastname successfully changed : EditingContactDetails()");
                            Console.WriteLine("Do you want to update anything else, press y to update again,else press enter");
                            string inputAfterlastName = Console.ReadLine();
                            if (inputAfterlastName.ToLower() == "y")
                            {
                                nLog.LogInfo("User wants to update further information");
                                goto EditAgain;
                            }
                            else
                            {
                                nLog.LogInfo("Updation Process Completed : EditinContactDetails()");
                                break;
                            }
                        case 3:
address: Console.WriteLine("please enter the address");
                            string newaddress = Console.ReadLine();
                            if (contactDetails.address == newaddress)
                            {
                                Console.WriteLine("You entered same user name");
                                Console.WriteLine("Please enter details again");
                                goto address;
                            }
                            contactDetails.address = newaddress;
                            nLog.LogDebug("Debug successful, address successfully changed : EditingContactDetails()");
                            Console.WriteLine("Do you want to update anything else, press y to update again,else press enter");
                            string inputAfteraddress = Console.ReadLine();
                            if (inputAfteraddress.ToLower() == "y")
                            {
                                nLog.LogInfo("User wants to update further information");
                                goto EditAgain;
                            }
                            else
                            {
                                nLog.LogInfo("Updation Process Completed : EditinContactDetails()");
                                break;
                            }
                        case 4:
city: Console.WriteLine("please enter the city");
                            string newcity = Console.ReadLine();
                            if (contactDetails.city == newcity)
                            {
                                Console.WriteLine("You entered same detail");
                                Console.WriteLine("Please enter details again");
                                goto city;
                            }
                            contactDetails.city = newcity;
                            nLog.LogDebug("Debug successful, city successfully changed : EditingContactDetails()");
                            Console.WriteLine("Do you want to update anything else, press y to update again,else press enter");
                            string inputAftercity = Console.ReadLine();
                            if (inputAftercity.ToLower() == "y")
                            {
                                nLog.LogInfo("User wants to update further information");
                                goto EditAgain;
                            }
                            else
                            {
                                nLog.LogInfo("Updation Process Completed : EditinContactDetails()");
                                break;
                            }
                        case 5:
state: Console.WriteLine("please enter the state");
                            string newstate = Console.ReadLine();
                            if (contactDetails.state == newstate)
                            {
                                Console.WriteLine("You entered same detail");
                                Console.WriteLine("Please enter details again");
                                goto state;
                            }
                            contactDetails.state = newstate;
                            nLog.LogDebug("Debug successful, state successfully changed : EditingContactDetails()");
                            Console.WriteLine("Do you want to update anything else, press y to update again,else press enter");
                            string inputAfterstate = Console.ReadLine();
                            if (inputAfterstate.ToLower() == "y")
                            {
                                nLog.LogInfo("User wants to update further information");
                                goto EditAgain;
                            }
                            else
                            {
                                nLog.LogInfo("Updation Process Completed : EditinContactDetails()");
                                break;
                            }
                        case 6:
zip: Console.WriteLine("please enter the zip code");
                            int newzip = Convert.ToInt32(Console.ReadLine());
                            if (contactDetails.zip == newzip)
                            {
                                Console.WriteLine("You entered same detail");
                                Console.WriteLine("Please enter details again");
                                goto zip;
                            }
                            contactDetails.zip = newzip;
                            nLog.LogDebug("Debug successful, zip successfully changed : EditingContactDetails()");
                            Console.WriteLine("Do you want to update anything else, press y to update again,else press enter");
                            string inputAfterzip = Console.ReadLine();
                            if (inputAfterzip.ToLower() == "y")
                            {
                                nLog.LogInfo("User wants to update further information");
                                goto EditAgain;
                            }
                            else
                            {
                                nLog.LogInfo("Updation Process Completed : EditinContactDetails()");
                                break;
                            }
                        case 7:
phoneno: Console.WriteLine("please enter the zip code");
                            double newmobileno = Convert.ToDouble(Console.ReadLine());
                            if (contactDetails.phoneNo == newmobileno || newmobileno <= 200000)
                            {
                                Console.WriteLine("You either entered same details or wrong details");
                                Console.WriteLine("Please enter details again");
                                goto phoneno;
                            }
                            contactDetails.phoneNo = newmobileno;
                            nLog.LogDebug("Debug successful, phoneno successfully changed : EditingContactDetails()");
                            Console.WriteLine("Do you want to update anything else, press y to update again,else press enter");
                            string inputAfterphone = Console.ReadLine();
                            if (inputAfterphone.ToLower() == "y")
                            {
                                nLog.LogInfo("User wants to update further information");
                                goto EditAgain;
                            }
                            else
                            {
                                nLog.LogInfo("Updation Process Completed : EditinContactDetails()");
                                break;
                            }
                        case 8:
email: Console.WriteLine("please enter the email code");
                            string newemail = Console.ReadLine();
                            if (contactDetails.eMail == newemail)
                            {
                                Console.WriteLine("You entered same detail");
                                Console.WriteLine("Please enter details again");
                                goto email;
                            }
                            contactDetails.eMail = newemail;
                            nLog.LogDebug("Debug successful, email successfully changed : EditingContactDetails()");
                            Console.WriteLine("Do you want to update anything else, press y to update again,else press enter");
                            string inputAfteremail = Console.ReadLine();
                            if (inputAfteremail.ToLower() == "y")
                            {
                                nLog.LogInfo("User wants to update further information");
                                goto EditAgain;
                            }
                            else
                            {
                                nLog.LogInfo("Updation Process Completed : EditinContactDetails()");
                                break;
                            }
                        default:
                            Console.WriteLine("Wrong input entered");
                            Console.WriteLine("Do you want to input again");
                            string input = Console.ReadLine();
                            if (input.ToLower() == "y")
                            {
                                goto EditAgain;
                            }
                            else
                                break;

                    }
                }

                //ContactPersonInformation contact = new ContactPersonInformation();

            }
            //Console.WriteLine("Your input does not match our data");
            if (editCheck == 0)
            {
                Console.WriteLine("It looks like you are entering wrong details");
                nLog.LogError("Wrong details entered for editing");
                nLog.LogInfo("Nothing has been edited");
            }
            Console.WriteLine("Do you want to input again, press y to input details");

            string check = Console.ReadLine();
            if (check.ToLower() == "y")
            {
                nLog.LogInfo("details are being entered again by user");
                goto addingDetailsAgainForEditing;
            }
            contact.DisplayContactDetails();
        }
        public void DeletingContactDetails()
        {
addingDetailsForDeleting: Console.WriteLine("Please help us, first identify you");
            Console.WriteLine("Please enter your first name and phone no");
            string firstNm = Console.ReadLine();
            double mobileNo = Convert.ToDouble(Console.ReadLine());
            int index = 0;
            foreach (ContactDetails contactDetails in contactDetailsList)
            {
                if (contactDetails.firstName == firstNm && contactDetails.phoneNo == mobileNo)
                {
                    contactDetailsList.Remove(contactDetails);
                    Console.WriteLine("deletion operation successful");
                    nLog.LogDebug("Deletion Operation Successful:DeletingContactDetails()");
                    index++;
                    break;


                }

            }
            //Console.WriteLine("Your input does not match our data");
            if (index == 0)
            {
                Console.WriteLine("It looks like you are entering wrong details");
                nLog.LogError("Wrong details entered for deleting");
                nLog.LogInfo("Nothing has been deleted");
            }
            Console.WriteLine("Do you want to input again, press y to input details");

            string check = Console.ReadLine();
            if (check.ToLower() == "y")
            {
                nLog.LogInfo("details are being entered again by user:DeletingContactDetails()");
                goto addingDetailsForDeleting;
            }
            else
            {
                nLog.LogInfo("Process Completed");
            }

        }
    }

}
