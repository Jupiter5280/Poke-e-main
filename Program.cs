namespace Poke_e_main;

class Program
{
    static void Main(string[] args)
    {
        int x = 0, y = 0;
        ConsoleKeyInfo cki;

        string map = (  "----------\n" +
                        "|        |\n" +
                        "|        |\n" +
                        "|        |\n" +
                        "|        |\n" +
                        "----------\n");

        System.Console.WriteLine(map);

        while (true)
        {
            cki = System.Console.ReadKey();
            if (cki.KeyChar == 'w') y++;
            if (cki.KeyChar == 'a') x--;
            if (cki.KeyChar == 's') y--;
            if (cki.KeyChar == 'd') x++;
            System.Console.Clear();
            System.Console.WriteLine(map);
            System.Console.Write($"X: {x} Y: {y}");
        }
    }
}
