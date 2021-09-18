using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using webApplicationFTI.Model;

namespace webApplicationFTI.Services.Implementations
{

    public class PersonServiceImplementation : IPersonService

    {
        private volatile int count;

        public Person Create(Person person)
        {
            //simulando acesso ao banco
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 10; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        private Person MockPerson(int i)
        {
            string genero = "";
            if (i % 2 == 0) {
                genero = "Masculino";
            }
            else {
                genero = "Feminino";
            }
            
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person Last" + i,
                Address = "Some Address" + i,
                Gender = genero
            };               
            
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Anderson",
                LastName = "Macedo",
                Address = "Londrina-PR",
                Gender = "Masculino"
            };
        }

        public Person Update(Person person)
        {
            //simulando a atualização de dados no banco
            return person;
        }
    }
}
