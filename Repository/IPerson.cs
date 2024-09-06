using ControllersAndActionsASP.Models;

namespace ControllersAndActionsASP.Repository
{
    public interface IPerson
    {
        List<PersonModel> getAllPersons();

        PersonModel getPersonByAge(int age);
    }
}
