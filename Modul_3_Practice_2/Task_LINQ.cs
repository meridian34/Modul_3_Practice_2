using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul_3_Practice_2
{
    public class Task_LINQ
    {
        public void Start()
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact() { Name = "Andrey", PhoneNumber = "0958381076" });
            contacts.Add(new Contact() { Name = "Dima", PhoneNumber = "0958381033" });
            contacts.Add(new Contact() { Name = "Atom", PhoneNumber = "0000000000" });
            contacts.Add(new Contact() { Name = "Nobady", PhoneNumber = null });
            contacts.Add(new Contact() { Name = "Andrey", PhoneNumber = string.Empty });
            Console.WriteLine("Task_LINQ result:");
            Print(contacts.Select(s => s.Name));
            Print(contacts.Where(w => !string.IsNullOrEmpty(w.PhoneNumber)));
            Print(contacts.FirstOrDefault(f => f.PhoneNumber == null));
            Print(contacts.ElementAt(2));
            Print(contacts.OrderBy(o => o.Name));
            Console.WriteLine(contacts.Contains(contacts.FirstOrDefault(f => f.PhoneNumber == null)));
        }

        private void Print(IEnumerable<string> strings)
        {
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }

        private void Print(IEnumerable<Contact> contacts)
        {
            foreach (var c in contacts)
            {
                Console.WriteLine($"{c.Name}  {c.PhoneNumber}");
            }

            Console.WriteLine();
        }

        private void Print(Contact contact)
        {
            Console.WriteLine($"{contact.Name}  {contact.PhoneNumber}");
            Console.WriteLine();
        }
    }
}
