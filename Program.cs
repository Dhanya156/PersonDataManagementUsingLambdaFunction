using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personDetails = new List<Person>();
            AddRecords(personDetails); 
        }

        public static void AddRecords(List<Person> personDetails)
        {
            personDetails.Add(new Person("123451", "Dhanya", "301 electronicCity Phase1 Bangalore", 21));
            personDetails.Add(new Person("123452", "Abhishek", "302 electronicCity Phase1 Bangalore", 41));
            personDetails.Add(new Person("123453", "Rachana", "303 electronicCity Phase1 Bangalore", 61));
            personDetails.Add(new Person("123454", "Arun", "201 electronicCity Phase2 Bangalore", 32));
            personDetails.Add(new Person("123455", "Maana", "121 phase2 Mysore", 18));
            personDetails.Add(new Person("123451", "Aradhana", "101 Whitefiled Bangalore", 28));
        }

    }
}
