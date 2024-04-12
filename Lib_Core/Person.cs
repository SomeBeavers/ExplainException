#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Framework
{
    public class Person
    {
        public List<Person> persons;
        public bool InsertPerson(Person? person)
        {
            if (person is null)
            {
                throw new ArgumentNullException(nameof(person));
            }
            
            try
            {
                persons.Add(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return true;
        }
    }
}
