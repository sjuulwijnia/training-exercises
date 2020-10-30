using Entities;
using EntityFakers;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI.Tests.Mocks
{
    public class MockPersonInMemoryRepository : IPersonRepository
    {
        private static readonly PersonFaker _personFaker;
        private static readonly IList<Person> _persons;

        static MockPersonInMemoryRepository()
        {
            _personFaker = new PersonFaker();
            _persons = _personFaker.Generate(100);
        }

        public IQueryable<Person> Get()
        {
            return _persons.AsQueryable();
        }

        public Person GetById(int id)
        {
            return _persons.FirstOrDefault(p => p.Id == id);
        }

        public bool Delete(int id)
        {
            var person = GetById(id);
            if (person == null)
            {
                return false;
            }

            _persons.Remove(person);

            return true;
        }

        public bool Insert(Person inserted)
        {
            if (inserted == null)
            {
                return false;
            }

            if (inserted.Id != 0)
            {
                return false;
            }

            inserted.Id = _personFaker.Generate(1).First().Id;
            _persons.Add(inserted);

            return true;
        }

        public bool Update(Person updated)
        {
            if (updated == null)
            {
                return false;
            }

            var person = GetById(updated.Id);
            if (person == null)
            {
                return false;
            }

            person.Age = updated.Age;
            person.FirstName = updated.FirstName;
            person.LastName = updated.LastName;

            return true;
        }
    }
}
