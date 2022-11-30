//Напишете програма, която извежда текущите дата и час.
//Done we simply add dateTime now above and we continiue with the code bellow using (now.ToString("F"));
namespace _08_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
        }
    }
}