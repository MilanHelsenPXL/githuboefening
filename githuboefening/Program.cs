namespace githuboefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\tMats Huygens\n----------------------------");
            Console.ResetColor();
            Console.WriteLine($"{"Opleiding: ",-15}Graduaat Programmeren");
            Console.WriteLine($"{"Klasgroep: ",-15}1PROE");
            Console.WriteLine($"{"Leukste olod: ",-15}C# Essentials");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGroetjes van MatsiePatsie");
        }
    }
}
