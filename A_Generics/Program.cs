namespace A_Generics;

internal class Program
{
    static void Main(string[] args)
    {
        var book = new Book { Isbn = "1111", Title = "C# Advanced" };

        /////////////without generic

        //var numbers = new List();
        //numbers.Add(10);

        //var books = new BookList();
        //books.Add(book);

        ///////////generics

        //var numbers = new GenericList<int>();
        //numbers.Add(10);

        //var books = new GenericList<Book>();
        //books.Add(book);

        //var dictionary = new GenericDictionary<string, Book>();
        //dictionary.Add("1234", book);

        //////////////constraints on the generic data type

        var number = new Nullable<int>(5);

        Console.WriteLine("Has value?" + number.HasValue);
        Console.WriteLine("Value: " + number.GetValueOrDefault());

    }
}

internal class Book : Product
{
    internal string Title { get; set; }

    internal string Isbn { get; set; }

    internal string Description { get; set; }

    internal string Author { get; set; }
}

internal class Product
{
    internal int Id { get; set; }

    internal string Name { get; set; }

    internal double Price { get; set; }
}