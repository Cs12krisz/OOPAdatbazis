using OOPAdatbazis.Services;

namespace OOPAdatbazis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az adatbázis nevét: ");
            string dbName = Console.ReadLine();
            ISqlStatements dataBase = new Library();
            ISqlStatements garage = new Cars();
            //Connect conn = new Connect(dbName);


            foreach (var item in dataBase.GetAllData(dbName))
            {

                var book = item.GetType().GetProperties();
                Console.WriteLine($"{book[0].Name} = {book[0].GetValue(item)}, {book[1].Name} = {book[1].GetValue(item)}, {book[2].Name} = {book[2].GetValue(item)}, {book[3].Name} = {book[3].GetValue(item)}");
            }




        }
    }
}
