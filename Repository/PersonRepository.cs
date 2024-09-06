using ControllersAndActionsASP.Models;
using System.Linq;

namespace ControllersAndActionsASP.Repository
{
    public class PersonRepository : IPerson
    {
        public List<PersonModel> getAllPersons()
        {
            return dataSource();
        }

        public PersonModel getPersonByAge(int age)
        {
            //x is data model
            return dataSource().Where(x => x.personAge == age).FirstOrDefault();
        }

        //for data Source
        private List<PersonModel> dataSource() {

            var persons = new List<PersonModel> {
                new PersonModel { personName = "Sarmad", personAge = 24, personProfession = "Programmer"},
                new PersonModel { personName = "Jalbani", personAge = 16, personProfession = "Student" },
                new PersonModel { personName = "Ali", personAge = 5, personProfession = "Child"}
            };

            return persons;
        }

    }
}
