using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_pattern
{
    sealed class PersonalRepository
    {
        private PersonalRepository() { }

        private static PersonalRepository _instance;


        public static PersonalRepository Getinstance()
        {
            if (_instance == null)
            {
                _instance = new PersonalRepository();
            }

            return _instance;
        }

        List<Person> people = new List<Person>();

        public void Add(Person person)
        {

            people.Add(person);

        }

        public List<Person> GetAll()
        {
            return people;
        }
    }
}
