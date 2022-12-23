using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            int personcount = 3;

            for (int i = 0; i < personcount; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                stack.Push(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < personcount; i++)
            {
                Person person = (Person)stack.Pop();
                Console.WriteLine(person.ToString());
            }
            Console.ReadKey();
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public override string ToString()
            {
                return Name + " - " + Age;
            }
        }
    }
    }
    

