﻿using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Person> listOfpeople = new PhoneBookList();

        }
        public Person PhoneBookList()
        {
             
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
 