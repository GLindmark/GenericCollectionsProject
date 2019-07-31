using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsProject {


    public class Customers {

        List<Customer> customerList = new List<Customer>();//creates a new dynamic list of customer instances

        public void LoadCustomers() {
            var cust1 = new Customer { Name = "P&G", State = "OH"};//this is how you can initialze a class without using constructors
            var cust2 = new Customer { Name = "Microsoft", State = "WA" };
            var cust3 = new Customer { Name = "Target", State = "MN" };


            customerList.Add(cust1);
            customerList.Add(cust2);
            customerList.Add(cust3);

        }

        public void PrintCustomers() {

            foreach(var cust in customerList) {//the cust can be anything, like "fred" and it pulls from the collection "customerList"


                Console.WriteLine($"Customer {cust.Name} is in the State of {cust.State}");



                }
            




        }

    }

    public class Customer {
        public string Name { get; set; }
        public string State { get; set; }

    }
}
