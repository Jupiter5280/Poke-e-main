using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_e_main
{
    internal class SceneManager
    {
        public int mapRadius = 7;
        int MAP_X = 84, MAP_Y = 85;

        public SceneManager() { }
        void PrintMap(string[] map, int x, int y, int mapRadius)
        {
            string ps = map[y].Substring(x - mapRadius, mapRadius) + "P" + map[y].Substring(x + 1, mapRadius);

            for (int i = mapRadius; i > 0; i--)
            {
                int strLength = mapRadius * 2 + 1;
                System.Console.WriteLine(map[y - i].Substring(x - mapRadius, (strLength)));
            }

            System.Console.WriteLine(ps);

            for (int i = 1; i < mapRadius; i++)
            {
                System.Console.WriteLine(map[y + i].Substring(x - mapRadius, (mapRadius * 2 + 1)));
            }

            /*
            System.Console.WriteLine(map[y - 3].Substring(x - 3, 7));
            System.Console.WriteLine(map[y - 2].Substring(x - 3, 7));
            System.Console.WriteLine(map[y - 1].Substring(x - 3, 7));
            System.Console.WriteLine(ps);
            System.Console.WriteLine(map[y + 1].Substring(x - 3, 7));
            System.Console.WriteLine(map[y + 2].Substring(x - 3, 7));
            System.Console.WriteLine(map[y + 3].Substring(x - 3, 7));
            */
        }
        public void LoadScene(string[] map, int player_x, int player_y)
        {
            ConsoleKeyInfo cki;

            while (true)
            {
                cki = System.Console.ReadKey(true);
                if (cki.KeyChar == 'w' && player_y >= (mapRadius + 1)) player_y--;
                if (cki.KeyChar == 'a' && player_x >= (mapRadius + 1)) player_x--;
                if (cki.KeyChar == 's' && player_y <= (MAP_Y - (mapRadius + 1))) player_y++;
                if (cki.KeyChar == 'd' && player_x <= (MAP_X - (mapRadius + 1))) player_x++;
                System.Console.Clear();

                PrintMap(map, player_x, player_y, this.mapRadius);


                System.Console.Write($"X: {player_x} Y: {player_y}");
            }
        }
    }
}
