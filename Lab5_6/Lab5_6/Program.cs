using System;

namespace Lab5_6
{
    class Program
    {
        public struct Customer
        {
            public string first_name;
            public string last_name;
            public int age;
            public bool hasMembership;
        }

        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.first_name = "Randy";
            customer1.last_name = "Morgan";
            customer1.age = 28;
            customer1.hasMembership = true;

            customer2.first_name = "Ichigo";
            customer2.last_name = "Kurosaki";
            customer2.age = 16;
            customer2.hasMembership = false;

            customer3.first_name = "Anakin";
            customer3.last_name = "Skywalker";
            customer3.age = 25;
            customer3.hasMembership = false;

            Customer[] allCustomers = { customer1, customer2, customer3 };
            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].first_name + "" + allCustomers[i].last_name + "NOT ALLOWED!");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + "" + allCustomers[i].last_name + "Yeah Sure");
                }
                if (allCustomers[i].hasMembership == true)
                {
                    Console.WriteLine(allCustomers[i].first_name + "" + allCustomers[i].last_name + "Premium Service");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + "" + allCustomers[i].last_name + "Boring Service");
                }
            }
        }
    }
}







