
using Domain;
using practik.Data;
using practik.NewFolder;
using System;
using System.Reflection;

namespace practik
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.age = 44;
            //Console.WriteLine(person.age);

            //Employee employee1 = new Employee();
            //Console.WriteLine(employee1.age);

            //Dog dog = new Dog("reks");
            //Console.WriteLine(dog.name);

            //Dog dog2 = new Dog("cek");
            //Console.WriteLine(dog2.name);

            //Employee employee = new Employee("2737748");

            //Person person = new Person();

            //show private fields with reflection
            //typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "Cracked");

            //var showSurname = typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);

            //Console.WriteLine(showSurname);

            //Person person = new Person();

            //person.Age = 8;

            //Console.WriteLine(person.Age);

            //Person person = new Person();

            //Car car = new Car();
            //MyCar car1 = new MyCar();

            Group group = new Group();
            group.Name = "P414";
            Console.WriteLine(group.Name);
        }

    }
}
