using Bogus;

namespace EntityFakers
{
    public class PersonFaker : Faker<Entities.Person>
    {
        public PersonFaker() : base("nl")
        {
            StrictMode(true);
            
            RuleFor(p => p.Id, f => f.IndexGlobal);
            RuleFor(p => p.FirstName, f => f.Name.FirstName());
            RuleFor(p => p.LastName, f => f.Name.LastName());
            RuleFor(p => p.Age, f => f.Random.Number(20, 60));
        }
    }
}
