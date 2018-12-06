using System;
namespace PhoneBook
{
    public class Entry
    {
        public string name { get; set; }
        public string phoneNo { get; set; }

        public Entry(string name, string phoneNo)
        {
            this.name = name;
            this.phoneNo = phoneNo;
        }
    }

}