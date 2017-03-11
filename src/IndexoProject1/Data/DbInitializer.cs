using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IndexoProject1.Models;

namespace IndexoProject1.Data
{
    public class DbInitializer
    {
        public static void Initialize(IndexcoDbContext context)
        {
          context.Database.EnsureCreated();

            if (context.Customers.Any())
            {
                return; // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer {OrganizationName="Test", OrganizationNumbers=1234, ContactPerson="Data"},
                new Customer {OrganizationName="Test1", OrganizationNumbers=2345, ContactPerson="DAta2" }
            };
            foreach(Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var addresses = new Address[]
            {
                new Address {CustomerID=1, City="Oslo", Country="Norway", Email="abc@gmail.com", PostNumber=0971, StreetName="Dronningsgate", Telephone=48612073},
                new Address {CustomerID=2, City="Kristiansand", Country="Norway", Email="abc@gmail.com", PostNumber=0971, StreetName="Jon lilletuns vei", Telephone=234454}
            };
            foreach(Address a in addresses)
            {
                context.Addresses.Add(a);
            }
            context.SaveChanges();
        }
    }
}
