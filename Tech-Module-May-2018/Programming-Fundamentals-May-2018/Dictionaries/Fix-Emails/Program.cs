using System;
using System.Collections.Generic;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                if (!email.EndsWith("uk") && !email.EndsWith("us"))
                {
                    contacts.Add(name, email);
                }

                name = Console.ReadLine();
            }

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }
        }
    }
}
