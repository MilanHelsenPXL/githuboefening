namespace githuboefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  __  __ _ _               _    _      _                \r\n |  \\/  (_) |             | |  | |    | |               \r\n | \\  / |_| | __ _ _ __   | |__| | ___| |___  ___ _ __  \r\n | |\\/| | | |/ _` | '_ \\  |  __  |/ _ \\ / __|/ _ \\ '_ \\ \r\n | |  | | | | (_| | | | | | |  | |  __/ \\__ \\  __/ | | |\r\n |_|  |_|_|_|\\__,_|_| |_| |_|  |_|\\___|_|___/\\___|_| |_|\r\n                                                        \r\n                                                        ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\tMats Huygens\n----------------------------");
            Console.ResetColor();
            Console.WriteLine($"{"Opleiding: ",-15}Graduaat Programmeren");
            Console.WriteLine($"{"Klasgroep: ",-15}1PROE");
            Console.WriteLine($"{"Leukste olod: ",-15}C# Essentials");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGroetjes van MatsiePatsie");
            Console.ResetColor();
        }
    }
}
