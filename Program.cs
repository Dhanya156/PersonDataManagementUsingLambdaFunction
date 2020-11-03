using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            ///Creating object for class Person using List
            List<Person> personDetails = new List<Person>();
            ///Calling method AddRecords
            AddRecords(personDetails);
            Retrieve_Top_2Records_From_List_For_Age_LessThan60(personDetails);
            Retrieve_Records_From_List_For_Age_Between_13_To_18(personDetails);
            Retrieve_Average_Age_In_The_List(personDetails);
            Check_For_Specific_Name_In_List(personDetails);
            Remove_Specific_Name_From_List(personDetails);
        }

        /// <summary>Adds the records.</summary>
        /// <param name="personDetails">The person details.</param>
        /// UC1 Add Defalut Values in created List
        public static void AddRecords(List<Person> personDetails)
        {
            personDetails.Add(new Person("123451", "Dhanya", "301 electronicCity Phase1 Bangalore", 21));
            personDetails.Add(new Person("123452", "Abhishek", "302 electronicCity Phase1 Bangalore", 41));
            personDetails.Add(new Person("123453", "Rachana", "303 electronicCity Phase1 Bangalore", 61));
            personDetails.Add(new Person("123454", "Arun", "201 electronicCity Phase2 Bangalore", 32));
            personDetails.Add(new Person("123455", "Maana", "121 phase2 Mysore", 18));
            personDetails.Add(new Person("123451", "Aradhana", "101 Whitefiled Bangalore", 28));
        }

        /// <summary>
        ///UC2 Method to retrieve top two records from list for age lessthan 60
        /// </summary>
        /// <param name="personDetails"></param>
        public static void Retrieve_Top_2Records_From_List_For_Age_LessThan60(List<Person> personDetails)
        {
            foreach (Person person in personDetails.FindAll(p => (p.Age <= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge: " + person.Age);
            }
        }

        /// <summary>
        /// UC3 Retrieve all record from the list for age between 13 to 18
        /// </summary>
        /// <param name="personDetails"></param>
        public static void Retrieve_Records_From_List_For_Age_Between_13_To_18(List<Person> personDetails)
        {
            foreach (Person person in personDetails.FindAll(p => (p.Age >= 13 && p.Age <= 18)))
            {
                Console.WriteLine("Name : " +person.Name + "\t\tAge : " + person.Age) ;
            }
        }

        /// <summary>UC4 Retrieves the average age in the list.</summary>
        /// <param name="personDetails">The person details.</param>
        public static void Retrieve_Average_Age_In_The_List(List<Person> personDetails)
        {
            double averageAge = personDetails.Average(p => p.Age);
            Console.WriteLine("The average age of persons stored in the list is : + averageAge");
        }

        /// <summary>UC5 Checks for specific name in list.</summary>
        /// <param name="personDetails">The person details.</param>
        public static void Check_For_Specific_Name_In_List(List<Person> personDetails)
        {
            ///Checking Whether the Person with name Dhanya is there in list
            foreach (Person person in personDetails.FindAll(p => (p.Name == "Dhanya")))
            {
                Console.WriteLine("Yes, the person is in list");
            }
        }

        /// <summary>UC6 Skips the record from the list for age lessthan 60.</summary>
        /// <param name="personDetails">The person details.</param>
        public static void Skip_Record_From_The_List_For_Age_Lessthan_60(List<Person> personDetails)
        {
            foreach (Person person in personDetails.SkipWhile(p => (p.Age < 60)))
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }

        /// <summary>UC7 Removes the specific name from list.</summary>
        /// <param name="personDetails">The person details.</param>
        public static void Remove_Specific_Name_From_List(List<Person> personDetails)
        {
            personDetails.RemoveAll(p => (p.Name == "Maana"));
            ///Checking whether the person is in list or not
            if (personDetails.TrueForAll(p => p.Name == "Maana"))
            {
                Console.WriteLine("The person still present in list");
            }
            else
                Console.WriteLine("The person is not in list"); 
        }
    }
}
