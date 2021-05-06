using System;

namespace Singleton_pattern
{
    class Program
    {

        static void Foo1()
        {
            var rep = PersonalRepository.Getinstance();
            rep.Add(new Person { Name = "Name", Age = 18, Surname = "Surname" });
            rep.Add(new Person { Name = "Name2", Age = 20, Surname = "Surname2" });

        }
        static void Foo2()
        {
            var rep = PersonalRepository.Getinstance();

            foreach (var item in rep.GetAll())
            {
                Console.WriteLine($"{item.Name} {item.Age} {item.Surname}");
            }
        }
        static void Main(string[] args)
        {
        
            Foo1();
            Foo2();
        }
    }
}
