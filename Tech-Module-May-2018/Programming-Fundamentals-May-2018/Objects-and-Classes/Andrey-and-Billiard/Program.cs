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
            Dictionary<string, Customer> customers = new Dictionary<string, Customer>();
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
                if (customers.ContainsKey(customerName))
                {
                    if (customers[customerName].ShoppingList.ContainsKey(customerProduct))
                    {
                        customers[customerName].ShoppingList[customerProduct] += customerProductsAmount;
                        customers[customerName].Bill += products[customerProduct] * customerProductsAmount;
                    }
                    else
                    {
                        customers[customerName].ShoppingList.Add(customerProduct, customerProductsAmount);
                        customers[customerName].Bill += products[customerProduct] * customerProductsAmount;  // calculate the bill (find the product in the product dict and multiplies it by the amount);
                    }
                }
                else
                {
                    currentCustomer.ShoppingList.Add(customerProduct, customerProductsAmount);
                    currentCustomer.Bill += products[customerProduct] * customerProductsAmount;
                    customers.Add(customerName, currentCustomer);
                }
            }
            foreach (var customer in customers.OrderBy(x => x.Key))
            {
                Console.WriteLine(customer.Key);
                foreach (var product in customer.Value.ShoppingList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Value.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {customers.Select(x => x.Value.Bill).Sum():f2}");
        }
    }
    class Customer
    {
        public Dictionary<string, decimal> ShoppingList { get; set; }
        public decimal Bill { get; set; }
        public Customer()
        {
            ShoppingList = new Dictionary<string, decimal>();
        }
    }
}
