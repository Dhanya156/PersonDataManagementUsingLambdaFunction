using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    /// <summary>
    /// Creating a Class Person
    /// </summary>
    public class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        /// <summary>Initializes a new instance of the <see cref="Person" /> class.</summary>
        /// <param name="ssn">The SSN.</param>
        /// <param name="name">The name.</param>
        /// <param name="adress">The adress.</param>
        /// <param name="age">The age.</param>
        public Person(string ssn, string name, string adress, int age)
        {
            SSN = ssn;
            Name = name;
            Address = adress;
            Age = age;
        }
    }
}
