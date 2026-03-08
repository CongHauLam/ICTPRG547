// See https://aka.ms/new-console-template for more information
using ICTPRG547.Model;
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("001", "Brendon", "Lam");
        Student s2 = new Student("001", "Brendon", "Lam");
        Student s3 = new Student("002", "Junifer", "Felipe");

        Console.WriteLine(s1.ToString());

        Console.WriteLine("Equals test:");
        Console.WriteLine(s1.Equals(s2));

        Console.WriteLine("Operator == test:");
        Console.WriteLine(s1 == s2);

        Console.WriteLine("Operator != test:");
        Console.WriteLine(s1 != s3);

        Console.WriteLine("HashCode:");
        Console.WriteLine(s1.GetHashCode());

        Console.ReadKey();
    }
}