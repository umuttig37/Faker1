using System;

namespace Nuget1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Person-----------------------------------------");
            Console.WriteLine(Faker.Name.FullName());
            Console.WriteLine(Faker.Country.Name());
            Console.WriteLine(Faker.Address.StreetName());
            Console.WriteLine(Faker.Identification.UsPassportNumber());
            Console.WriteLine(Faker.Phone.Number());
            Console.WriteLine(Faker.Company.Name());

            Console.WriteLine("\nSecond Person----------------------------------------");
            Console.WriteLine(Faker.Name.FullName());
            Console.WriteLine(Faker.Country.Name());
            Console.WriteLine(Faker.Address.StreetName());
            Console.WriteLine(Faker.Identification.UsPassportNumber());
            Console.WriteLine(Faker.Phone.Number());
            Console.WriteLine(Faker.Internet.Email());

            Console.WriteLine("\nThird Person------------------------------------------");
            Console.WriteLine(Faker.Name.FullName());
            Console.WriteLine(Faker.Country.Name());
            Console.WriteLine(Faker.Address.StreetName());
            Console.WriteLine(Faker.Lorem.Sentence());
            Console.WriteLine(Faker.Phone.Number());
            Console.WriteLine(Faker.Internet.Email());
            Console.WriteLine(Faker.Internet.UserName());





        }
    }
}
