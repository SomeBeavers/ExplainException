using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_Framework;

namespace ConsoleApp_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.InsertPerson(person);
        }
    }
}
