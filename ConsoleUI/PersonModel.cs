using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
        public string FirstName { private get; set; } // can only be retrieved within this class, anyone can set
        public string LastName { get; private set; } // can only be set within this class, anyone can read
        //public int Age { get; set; } // this would allow to set any age (negative, or 1000)

        private string _password;

        public string Password
        {
            // we can delete the get because it's not needed (basically a private get)
            set { _password = value; }
        }

        public string FullName // allows us to not need and repeat code to print the full name (and also to access data that may not be accessible in the Program.cs)
        {
            get
            {
                return $"{FirstName} {LastName}"; // Fullname can still access the FirstName that has private get since it's in the same class
            }
        }


        private int _age; // private backing field (_), should not be modified directly, only in the Age property itself

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range.");
                }
            }
        }
        //public string SSN { get; set; } // Social Security Number 123-45-6789

        private string _ssn;

        public string SSN
        {
            get
            {
                // 123-45-6789 (11 chars) - 4 = 7
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4); // only gives the last 4 digits

                return output;
            }
            set { _ssn = value; }
        }

        

        public PersonModel(string lastName) // constructor (sepcial method used when "building" our house
        {
            LastName = lastName; // here the LastName can be set since it's within the class (but it needs to be passed in)
        }

        // Method overloading - we can have multiple constructors for same model,
        // this one allows us that the method can be called without passing in any data (in this case no LastName)
        public PersonModel()
        {

        }
    }
}
