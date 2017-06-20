using System;
using System.Collections;
//
// Simple business object.

namespace IEnumerable01
{
    class Program
    {
        static void Main()
        {
            Person[] peopleArray = new Person[3]
            {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);
            Console.ReadLine();
        }
    }
    public static class A
    {
        public static void test()
        {
            return ;
        }


    }
}
/* This code produces output similar to the following:
 *
 * John Smith
 * Jim Johnson
 * Sue Rabon
 *
 */
