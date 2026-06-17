using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Bark"); // constructor is called here (usually hidden if not declared explicitly) (the LastName is passed when calling the method).
            // A reason of doing like this, is to make sure that at least the minimum ammount of data is set, so it is required and the model is valid (like a first and last name at least).

            person.FirstName = "Neven";
            //person.LastName = "Bark";
            person.Age = 16;
            person.SSN = "123-45-6789";

            Console.WriteLine(person.FullName); // FirstName can be retrieved using only FullName
            Console.WriteLine(person.SSN);

            AddressModel address = new AddressModel();
            address.StreetAddress = "Barkstrasse 42";
            address.City = "Barkcity";
            address.State = "Barkstate";
            address.ZipCode = 12345;

            Console.WriteLine(address.FullAddress);

            Console.ReadLine();
        }
    }
}
