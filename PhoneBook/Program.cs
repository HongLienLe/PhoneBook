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
                Entry newPerson = newEntry(userEntryNamePhoneNo);
                PhoneBooks.Add(i, newPerson);
                i++;

            }

            Console.WriteLine("Query:");

            userEntry = Console.ReadLine();

            foreach (KeyValuePair<int, Entry> item in PhoneBooks)
            {
                if(userEntry == item.Value.name){

                    Console.WriteLine($"Number is {item.Value.phoneNo}");

                } else if (userEntry == item.Value.phoneNo){
                    Console.WriteLine($"Name is {item.Value.name}");
                } else {
                    Console.WriteLine("Not there");
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
/*Task Phonebook: create a phonebook application. Initially the user can enter name and 11 digit numbers pairs.
 * If the user enters a blank line you move to phrase 2 where they can query the phone book: given an 11 digit number returns the name of a person.
 * Or given a name returns the number of the person. Return a useful error message if the person does not exist.

E.g. sample input/output

>Enter:
David 12345678901
>Enter:
Tom 12345678900
>Enter:

>Query:
David
>Number is 1234567890
>Query:
12345678900
>Name is Tom
>Query:
*/
 