using webApplicationFTI.Model;
using System.Collections.Generic;

namespace webApplicationFTI.Model
{

    public interface IPersonService
    {

        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);







    }
         



}