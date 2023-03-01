using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Excersise3;

public class DataValidation
{
    [StringLength(100), Required]
    public string Name { get; init; }
    [Range(0,120)]
    public int Age { get; set; }
    [EmailAddress]
    public string Email { get; set; }

    public DataValidation(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
    public DataValidation(string name, int age)
    {
        Name = name;
        Age = age;
    }


    public static void Main(string[] args)
    {
        var person1 = new DataValidation("John", 30, "john@example.com");

        Console.WriteLine(person1.ValidatePerson()); // no exception

 

        var person2 = new DataValidation(null, 150);

        try

        {

            Console.WriteLine(person2.ValidatePerson());

        }

        catch (ArgumentException ex)

        {

            Console.WriteLine(ex.Message); // "Name must be between 1 and 100 characters."

        }

 

        var person3 = new DataValidation("Jane", -10, "jane@example.com");

        try

        {

            Console.WriteLine(person3.ValidatePerson());

        }

        catch (ArgumentException ex)

        {

            Console.WriteLine(ex.Message); // "Age must be between 0 and 120."

        }

 

        

        try

        {
            var person4 = new DataValidation("Bob", 40, "invalid-email");

            Console.WriteLine(person4.ValidatePerson());

        }

        catch (ArgumentException ex)

        {

            Console.WriteLine(ex.Message); // "Email must be a valid email address format."

        }
        
      

    }

    public bool ValidatePerson()
    {
        DataValidation person = new DataValidation(Name, Age, Email);
        var result = new List<ValidationResult>();
        var context = new ValidationContext(person);

        return Validator.TryValidateObject(person, context, result, true);
    }
}

/*
 * var person1 = new DataValidation()
        {
            Name = "Emil",
            Age = 140

        };
        var person2 = new DataValidation()
        {
            Name = "Børge",
            Age = 20,
            Email = "børge@gmail.com"

        };
        var person3 = new DataValidation()
        {
            Name = "Jens",
            Age = 33,
            Email = "Hej med dig jeg har ikke nogen email"

        };
 */