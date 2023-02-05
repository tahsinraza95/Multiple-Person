using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace AddressBookManagementSystem
{
    public class AddressBook
    {
        private Dictionary<string, string> book;

        public AddressBook()
        {
            book = new Dictionary<string, string>();
        }

        public void AddPerson(string name, string phoneNumber)
        {
            if (book.ContainsKey(name))
            {
                Console.WriteLine($"{name} already exists in the address book with phone number {book[name]}");
                return;
            }
            book.Add(name, phoneNumber);
            Console.WriteLine($"{name} with phone number {phoneNumber} has been added to the address book"
                );
        }

        public void DeletePerson(string name)
        {
            if (!book.ContainsKey(name))
            {
                Console.WriteLine($"{name} not found in the address book");
                return;
            }

            book.Remove(name);
            Console.WriteLine($"{name} has been deleted from the address book");
        }

        public void DisplayBook()
        {
            if (book.Count == 0)
            {
                Console.WriteLine("Address book is empty");
                return;
            }

            foreach (KeyValuePair<string, string> entry in book)
            {
                Console.WriteLine($"Name: {entry.Key} - Phone Number: {entry.Value}");
            }
        }
    }





}
