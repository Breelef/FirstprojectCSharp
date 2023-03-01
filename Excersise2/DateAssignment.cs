namespace Firstproject;

public class DateAssignment
{
    public struct Date
    {
        
        private int year, month, day;

        public int Year
        {
            get => year;
            set => year = value;
        }

        public int Month
        {
            get => month;
            set => month = value;
        }

        public int Day
        {
            get => day;
            set => day = value;
        }

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public override string ToString()
        {
            return $"{year}-{month}-{day}";
        }
        public string IsValid()
        {
            try
            {
                DateTime dateToTest = new DateTime(year, month, day);
                return new Date(dateToTest.Year, dateToTest.Month, dateToTest.Day).ToString();
            }
            catch (Exception e)
            {
                return "Date is not valid \n" + e;
            }

        }
        
    }

    public static void Main(string[] args)
    {
        Date date1 = new Date(2023, 3, 22);
        Date date2 = new Date(2023, 2, 29);
        Date date3 = new Date(2023, 12, 1);
        Console.WriteLine("Date 1 is valid? " + date1.IsValid());

        Console.WriteLine("Date 2 is valid? " + date2.IsValid());

        Console.WriteLine("Date 3 is valid? " + date3.IsValid());

 

        Console.WriteLine("Date 1: " + date1.ToString());

        Console.WriteLine("Date 2: " + date2.ToString());

        Console.WriteLine("Date 3: " + date3.ToString());
    }

    
    
}
