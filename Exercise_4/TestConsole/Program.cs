using EntityFakers;
using System;
using System.Linq;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var faker = new PersonFaker();
            var fakePersons = faker.Generate(2000);

            var anonimisedList = from p in fakePersons select new { p.Age, p.LastName };
            foreach (var anonimisedPerson in anonimisedList)
            {
                Console.WriteLine($"- {anonimisedPerson.LastName.PadRight(15, ' ')} ({anonimisedPerson.Age})");
            }

            //var personsWithM = fakePersons.Where(p => p.FirstName.StartsWith("M") && p.LastName.StartsWith("M"));
            //foreach (var person in personsWithM)
            //{
            //    Console.WriteLine($"- #{person.Id.ToString().PadLeft(3, '0')}: {person.FirstName.PadRight(15, ' ')} {person.LastName.PadRight(15, ' ')} ({person.Age})");
            //}

            //var personsByAge = fakePersons
            //    .GroupBy(p => p.Age)
            //    .OrderBy(p => p.Key);

            //foreach (var groupAge in personsByAge)
            //{
            //    Console.WriteLine($"Age: {groupAge.Key} ({groupAge.Count()} persons)");
            //    foreach (var person in groupAge)
            //    {
            //        Console.WriteLine($"- #{person.Id.ToString().PadLeft(3, '0')}: {person.FirstName} {person.LastName} ({person.Age})");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
