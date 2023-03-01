public class Person
{
    private string name;
    private int age;
    private string email;
    private string message;

    public Person(string name, int age, string email, string message)
    {
        this.name = name;
        this.age = age;
        this.email = email;
        this.message = message;
    }
    public Person(string name, int age, string message)
    {
        this.name = name;
        this.age = age;
        this.message = message;
    }
    
    
    public static void Main(string[] args)
    {
        Person per1 = new Person("John Doe", 30, "john.doe@example.com", "The customer is between 30 and 40");
        Person per2 = new Person("Jane Doe", 25, "jane.doe@example.com", "The customer is under 30");
        Person per3 = new Person("Jim Smith", 35, "The customer is between 30 and 40");
        List<Person> personList = new List<Person>();
        personList.Add(per1);
        personList.Add(per2);
        personList.Add(per3);
        String personPrint = FindPersonEmail(per3);
        Console.WriteLine(personPrint);
        int ageToGet = GetPersonAge(personList);
        Console.WriteLine(ageToGet);
    }
    public static String FindPersonEmail(Person p)
    {
        return p.email ?? throw new Exception("No email");
    }

    public static int GetPersonAge(List<Person> pList)
    {
        int getAge = 0;
        foreach (var person in pList)
        {
            if (person.message is "The customer is between 30 and 40" && getAge < 31)
            {
                getAge = person.age;
            }
            
        }

        return getAge;
    }

    public override string ToString()
    {
        return $"Name: {name}\r\n Age:{age} \r\n Message:{message} \r\n Email:{email}";
    }
}