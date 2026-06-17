using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AddressModel
    {
        // Homework - Create a class that has properties for street address, city, state, and zip code.
        // Then add a FullAddress property that is read-only.

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string FullAddress
        {
            get
            {
                return $"{StreetAddress}, {City}, {State}, {ZipCode}";
            }
        }
    }
}
