// See https://aka.ms/new-console-template for more information
namespace ArchiveModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (var db = new ArchiveContext())
            {
                Console.WriteLine($"Database path: {db.DbPath}.");
            }
        }
    }
}

