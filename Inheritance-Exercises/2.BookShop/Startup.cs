
using System;

public class Startup
{
    public static void Main()
    {
        try
        {
            string author = Console.ReadLine();
            string title = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());

            var book = new Book(author, title, price);
            var goldenBook = new GoldenEditionBook(author, title, price);
            Console.WriteLine(book);
            Console.WriteLine(goldenBook);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        
    }
}

