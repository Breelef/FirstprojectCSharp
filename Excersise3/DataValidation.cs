using System.ComponentModel.DataAnnotations;

namespace Excersise3;

public class DataValidation
{
    [StringLength(100), Required]
    public string Name { get; init; }
    [Range(0,120)]
    public int Age { get; set; }
    [EmailAddress]
    public string Email { get; set; }


    public static void Main(string[] args)
    {
        var person1 = new DataValidation()
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
        bool check = ValidatePerson(person1);
        bool check2 = ValidatePerson(person2);
        bool check3 = ValidatePerson(person3);
        Console.WriteLine(check);
        Console.WriteLine(check2);
        Console.WriteLine(check3);

    }

    public static bool ValidatePerson(DataValidation person)
    {
        var result = new List<ValidationResult>();
        var context = new ValidationContext(person);

        return Validator.TryValidateObject(person, context, result, true);
    }
}