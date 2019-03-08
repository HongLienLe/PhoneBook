using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            IDictionary<int, Entry> PhoneBooks = PhoneBookList();
            string userEntry = " ";
            int i = 0;


            while (userEntry != "")
            {
                Console.WriteLine("Enter:");
                userEntry = Console.ReadLine();
                if (userEntry == "")
                {
                    break;
                }
                string[] userEntryNamePhoneNo = userEntry.Split(' ');

                if (userEntryNamePhoneNo.Length == 2)
                {
                    Entry newPerson = newEntry(userEntryNamePhoneNo);
                    PhoneBooks.Add(i, newPerson);
                    i++;
                } else {
                    Console.WriteLine("Please enter first name, space and then number.");
                }

            }

            Console.WriteLine("Query:");

            userEntry = Console.ReadLine();

            foreach (KeyValuePair<int, Entry> item in PhoneBooks)
            {
                if(userEntry == item.Value.Name){

                    Console.WriteLine($"Number is {item.Value.PhoneNo}");

                } else if (userEntry == item.Value.PhoneNo){
                    Console.WriteLine($"Name is {item.Value.Name}");
                } else {
                    Console.WriteLine("Name and Number does not Exist");
                }

            }


        }
        public static IDictionary<int, Entry> PhoneBookList()
        {
            IDictionary<int, Entry> people = new Dictionary<int, Entry>();
                                        
            return people;
        }

        public static Entry newEntry(string[] userEntry){

            string name = userEntry[0];

            string phoneNo =  userEntry[1];

            Entry person = new Entry(name, phoneNo);

            return person;

            }
        }
}