using OOPAdatbazis.Services;

namespace OOPAdatbazis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az adatbázis nevét: ");
            string dbName = Console.ReadLine();
            Console.Write("Kérem a tábla nevét: ");
            string choosentable = Console.ReadLine();
 
            if (choosentable == "cars")
            {
                ISqlStatements table = new Cars();
                List<object> cars = table.GetAllData(dbName);
                foreach (var item in cars)
                {

                    var car = item.GetType().GetProperties();
                    Console.WriteLine($"{car[0].Name} = {car[0].GetValue(item)}, {car[1].Name} = {car[1].GetValue(item)}, {car[2].Name} = {car[2].GetValue(item)}, {car[3].Name} = {car[3].GetValue(item)}");
                }
            }
            else
            {
                ISqlStatements database = new Library();
                List<object> books = database.GetAllData(dbName);
                foreach (var item in books)
                {

                    var book = item.GetType().GetProperties();
                    Console.WriteLine($"{book[0].Name} = {book[0].GetValue(item)}, {book[1].Name} = {book[1].GetValue(item)}, {book[2].Name} = {book[2].GetValue(item)}, {book[3].Name} = {book[3].GetValue(item)}");
                }
            }


        }
    }
}
