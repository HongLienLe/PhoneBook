using System;
namespace PhoneBook
{
    public class Entry
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }

        public Entry(string name, string phoneNo)
        {
            Name = name;
            PhoneNo = phoneNo;
        }
    }

}