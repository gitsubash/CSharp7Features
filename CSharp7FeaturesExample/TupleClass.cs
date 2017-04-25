using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7FeaturesExample
{
    class TupleClass
    {
        public void Init()
        {
            var names = GetDetails();
            WriteLine($"Firstname: {names.Item1} LastName: {names.Item2} Age: {names.Item3}");

            var names1 = GetDetails1();
            WriteLine($"Firstname: {names1.first} LastName: {names1.last} Age: {names1.age}");

            //returning tuples with literals names ???
            var names2 = GetDetails2();
            WriteLine($"Firstname: {names2.first} LastName: {names2.last} Age: {names2.age}");

            //Deconstruction of Tuples
            (string first, string last, int age) = GetDetails();
            WriteLine($"Firstname: {first} LastName: {last} Age: {age}");
            age++;
            WriteLine($"Tuples are value types as seen in Age: {age}");

            var (first1, last1, age1) = GetDetails();
            WriteLine($"Firstname: {first1} LastName: {last1} Age: {age1}");

            //int (a, b) = GetDetails11();

        }

        public void Issue()
        {
            var person = (Name: "Subash Paudyal", Age: 35);
            var jsonPerson = JsonConvert.SerializeObject(person);
            //Where are our keys gone?
            WriteLine($"JSON Details: {jsonPerson}");
            //Also, doesn't work when converting to dynamic object
            var dynamicPerson = (dynamic)person;
            WriteLine($"Dynamic Details: {dynamicPerson.Item1}");   //dynamicPerson.Name is not accessible (RuntimeBinder exception)

        }

        public (string,string,int) GetDetails()
        {
            return ("subash", "paudyal", 35);
        }

        // tuple elements have names
        public (string first, string last, int age) GetDetails1()
        {
            return ("subash", "paudyal", 35);
        }
        public (string first, string last, int age) GetDetails2()
        {
            return (first: "subash", last: "paudyal", age: 35); // named tuple elements in a literal
        }

        public (int, int) GetDetails11()
        {
            return (12, 35);
        }


    }
}
