using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace OpenCSVFile
{
    class People
    {
        /// <summary>
        /// Main method read the data from file
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\boss\source\repos\OpenCSV\People.csv";
            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');
                Person newPerson = new Person();

                newPerson.Name = entries[0];
                newPerson.EmailAddress = entries[1];
                newPerson.PhoneNumber = entries[2];
                newPerson.Country = entries[3];

                people.Add(newPerson);
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{ person.Name } ,{ person.EmailAddress } , { person.PhoneNumber }  ,{ person.Country }");
            }
            //New Data added in file
            Console.WriteLine(" ");
            people.Add(new Person { Name = "Rajesh Sharma", EmailAddress = "rajesh@gmail.com", PhoneNumber = "+91-9128933564", Country = "India" });
            List<string> output = new List<string>();
            foreach (var person in people)
            {
                output.Add($"{ person.Name }, { person.EmailAddress } , { person.PhoneNumber } , { person.Country }");
            }
            Console.WriteLine("Person details added");
            Console.WriteLine("Writing into the file");
            File.WriteAllLines(filepath, output);
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.Name } ,{ person.EmailAddress }, { person.PhoneNumber } , { person.Country }");
            }
        }
    }
}