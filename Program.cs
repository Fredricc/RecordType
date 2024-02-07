namespace RecordType
{
    /// <summary>
    /// Example of a record type..
    /// </summary>
    /// <param name="FirstName"></param>
    /// <param name="LastName"></param>
    public record Person(string FirstName, string LastName);

    public record Employee(): Person("First", "Last");
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Person person1 = new Person("Steve", "Bandaman");
            Person person2 = new Person("Steve", "Bandaman");

            if (person1 == person2)
            {
                Console.WriteLine("Persons are equal.");
            }
            else
            {
            Console.WriteLine("Hello, persons are different.");

            }
        }
    }
}