using System;
namespace PhoneBook
{
    public class Entry
    {
        string name { get; set; }
        string phoneNo { get; set; }

        public Entry(string name, string phoneNo)
        {
            this.name = name;
            this.phoneNo = phoneNo;
        }
    }

}

// PLANNING BITCH

/* Enter:
 * Hong 213213213213
 * 
 * from here I want to seperate the two into two seperate variables. One as the Key and the other as the Value.
 * 
 * after this I need to declare it in my dictionary. 
 * 
 * IF the user enters ""
 * 
 * Then I want my program to look through the dictionary to get the value and display it.
 * 
 * What is the problem rn? Well mister I can't find the key using the value -_-'' 
 * 
 * Solution one - make two dictionaries?
 * 
 * for each to scan through so you can like see it.
 * 
 * 
 * Method one - Takes user input 
 * 
 */