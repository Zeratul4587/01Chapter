//Използвайте методите System.Console.ReadLine(), int.Parse() и
//System.DateTime.AddYears().
namespace _11_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;

            Console.WriteLine("Enter your name: ");

            // using the method
            // typecasting not needed
            // as ReadLine returns string
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");

            // Converted string to int
            age = Convert.ToInt32(Console.ReadLine());


            // check age for the user
            // allow voting if user is older than eighteen years old 
            //don't allow the users to be under/bellow eighteen years old 
            if (age >= 18)
            {
                Console.WriteLine("Hello " + name + "!"
                            + " You can vote");
            }
            else
            {
                Console.WriteLine("Hello " + name + "!"
                    + " Sorry you can't vote");
            }
        }
    }
}
    
