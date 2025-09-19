namespace OOPAdatbazis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az adatbázis nevét: ");
            string dbName = Console.ReadLine();
            Connect conn = new Connect(dbName);
        }
    }
}
