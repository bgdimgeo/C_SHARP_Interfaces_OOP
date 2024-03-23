using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);// Downcast орязва част от типа и затова няма sleep което по-надолу, т.е. сваляме нивото
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            //Console.WriteLine(person.Sleep);
        }
    }
}
