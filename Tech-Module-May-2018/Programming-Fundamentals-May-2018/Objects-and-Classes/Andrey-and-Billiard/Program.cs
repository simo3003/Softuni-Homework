using System;
using System.Collections.Generic;
using System.Linq;

namespace Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int productAmount = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            List<Customer> customers = new List<Customer>();
            List<string> input = new List<string>();
            for (int i = 1; i <= productAmount; i++)
            {
                input = Console.ReadLine().Split('-').ToList();
                string productName = input[0];
                decimal price = decimal.Parse(input[1]);
                if (products.ContainsKey(productName))
                {
                    products[productName] = price;
                }
                else
                {
                    products.Add(productName, price);
                }
            }
            input.Clear();
            while (true)
            {
                input = Console.ReadLine().Split('-', ',').ToList();
                if (input[0] == "end of clients")
                {
                    break;
                }
                string customerName = input[0];
                string customerProduct = input[1];
                if (!products.ContainsKey(customerProduct)) // if the product doesn't exist, continue
                {
                    continue;
                }
                decimal customerProductsAmount = decimal.Parse(input[2]);
                Customer currentCustomer = new Customer(); // create a new customer
                currentCustomer.Name = customerName; // name prop
                if (currentCustomer.ShoppingList.ContainsKey(customerProduct))
                {
                    currentCustomer.ShoppingList[customerProduct] += customerProductsAmount;
                }
                else
                {
                    currentCustomer.ShoppingList.Add(customerProduct, customerProductsAmount);  // add the current product and amount to the shoppinglist
                }
                currentCustomer.Bill += products[customerProduct] * customerProductsAmount; // calculate the bill (find the product in the product dict and multiplies it by the amount);
                customers.Add(currentCustomer);
            }

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.ShoppingList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            Console.WriteLine($"Total bill: {customers.Select(x => x.Bill).Sum():f2}");
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, decimal> ShoppingList { get; set; }
        public decimal Bill { get; set; }

        public Customer()
        {
            ShoppingList = new Dictionary<string, decimal>();
        }
    }
}
