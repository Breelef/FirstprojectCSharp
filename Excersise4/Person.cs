using System.Security.Cryptography;

namespace Excersise4;

public class Person
{
    private string Name { get; set; }
    private int Age { get; set; }
    private string Occupation { get; set; }
    private decimal Salary { get; set; }

    public static void Main(string[] args)
    {
        var person1 = new Person()
        {
            Name = "Emil",
            Age = 140,
            Occupation = "Koder",
            Salary = 322.8M

        };
        var person2 = new Person()
        {
            Name = "Børge",
            Age = 20,
            Occupation = "Murer",
            Salary = 32.8M

        };
        var person3 = new Person()
        {
            Name = "Jens",
            Age = 33,
            Occupation = "Fuglekigger",
            Salary = 2.3M

        };
        var person = new Person

        {

            Name = "John",

            Age = 30,

            Occupation = "Software Engineer",

            Salary = 75000.00m

        };

 

        var (name, age, occupation, salary) = person.GetPersonInfo();

 

        Console.WriteLine($"{name} is {age} years old and works as a {occupation}, earning {salary:C} per year.");
    }

    public Tuple<string, int, string, decimal> GetPersonInfo()
    {
        Tuple<string, int, string, decimal> person1 =
            new Tuple<string, int, string, decimal>(Name, Age, Occupation, Salary);
        return person1;
    }
}