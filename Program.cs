﻿namespace Poke_e_main;

class Program
{
    static void Main(string[] args)
    {
        int x = 10, y = 40;
        ConsoleKeyInfo cki;

        string[] map2 = { "#######", "#-----#", "#-----#", "#--M--+", "#-----#", "+-----#", "#-----#", "#######" };

        string[] map = {
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,,########,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#######,,.,,#------#,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,+-----#,,.,,#--E---#,,,,########,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,#-----#,,.,,#------#,,,,#------#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,#######,,,,,,#--b--#,,.,,#------+,,,,#------#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,#-----#,,,,,,#-----#,,.,,########,,,,+--H---#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,+-----#,,,,,,#-----#,,.,,,,,,,,,,,,,,#------#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,#--S--#,,,,,,#######,,.,,,,,,,,,,,,,,#------#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,#-----#,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,######+#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,#-----#,,,,,,,,,####,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,#-----#,,,,,,,,,#--#,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,######,#####+#,,,,,,,,,#W-+,,.,,,,######,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,#----#,,,,,,,,,,,,,,,,,#--#,,.,,,,#----#,,,,,,,,#######,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,#-H--#,,,,#######,,,,,,####,,.,,,,#-E--#,,####,,#-----#,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,#----#,,,,#-----#,,,,,,,,,,,,.,,,,#----#,,#--#,,#--H--#,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,#----#,,,,#-----#,,,,,,,,,,,,.,,,,####+#,,#H-#,,#-----#,,,####,,,,,,,,,,",
            ",,,,,,,,,,,,,##+###,,,,#--M--+,,,,,,,,,,,,.,,,,,,,,,,,,#--#,,+-----#,,,+H-#,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,#-----#,,,,,,,,,,,,.,,,,,,,,,,,,##+#,,#######,,,#--#,,,,,,,,,,",
            ",,,,,,,,,,,,####,,,,,,,+-----#,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,####,,,,,,,,,,",
            ",,,,,,,,,,,,#--#,,,,,,,#-----#,,####,,,,,...,,,,,,,,,,,,,,,,######+#,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,+S-#,,,,,,,#######,,+--#,,,,,...,,,,,,,,,,,,,,,,#------#,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,#--#,,,,,,,,,,,,,,,,#--#,,,,,...,,,,,,,,,,,,,,,,#------+,,,######,,,,,,,,",
            ",,,,######,,####,,,,,,,,,,,,,,,,#g-#,,,,,...,,~~~~,,,,,,,,,,#--B---#,,,#----#,,,,,,,,",
            ",,,,#-H--#,,,,,,,,,,,,,,,,,,,,,,#--#,,,,,...,~~~~~~,######,,#------#,,,#-H--#,,,,,,,,",
            ",,,,#----#,,,,,,,,,,,,,,,,,,,,,,#--#,,,,,...,~~~~~~,#-H--#,,#------#,,,#----#,,,,,,,,",
            ",,,,###+##,,,,,,,##+####,#####,,####,,,,,...,,~~~~,,#----#,,########,,,#----#,,,,,,,,",
            ",,,,,,,,,,,,,,,,,#-----#,#---#,,,,,,,,,,,...,,,,,,,,#+####,,,,,,,,,,,,,###+##,,,,,,,,",
            ",,,,,,,,,,,,,,,,,#--H--#,#---#,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,#-----#,#-W-#,,,,,,,,,,,...,,,,,,,,,,,,,,,,,,########,,,,,,,,,,,,,,,",
            ",,,,,,,#######,,,#-----#,#---#,,.....................,,,,,,,,,#--H---+,,,,,,,,,,,,,,,",
            ",,,,,,,#-----#,,,#######,#---#,,.....................,,,,,,,,,#------#,,,,######,,,,,",
            ",,,,,,,#--E--#,,,,,,,,,,,#+###,,..,,,,,,,,,,,,,,,,,..,,,,,,,,,########,,,,#----#,,,,,",
            ",,,,,,,#-----#,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,,,,,#-H--#,,,,,",
            ",,,,,,,#+#####,,,,########,,,,,,..,,###+####,,,,,,,..,,,,,,,,,,,,,,,,,,,,,#----+,,,,,",
            ",,,,,,,,,,,,,,,,,,+--W---#,,,,,,..,,#------#,,,,,,,..,,,,,,,,######,,,,,,,######,,,,,",
            ",,,,,,,,,,,,,,,,,,#------#,,,,,,..,,#------#,####,,..,,,,,,,,#-H--#,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,########,,,,,,..,,#--H---#,#--#,,..,,,,,,,,#----+,,,,,,,,,,,,,,,,,,",
            ",,,,#####,,,,,,,,,,,,,,,,,,####,..,,#------#,#H-#,,..,#####,,######,,,,#####,,,,,,,,,",
            ",,,,#---+,,##+#,,,#+#+###,,#--#,..,,#------#,+--#,,..,#-g-#,,,,,,,,,,,,#---#,,####,,,",
            ",,,,#---#,,#--#,,,#-----#,,#--#,..,,#+######,####,,..,#---+,,,,,,,,,,,,#---#,,#--#,,,",
            ",,,,#-H-#,,#H-#,,,#--H--#,,#H-#,..,,,,,,,,,,,,,,,,,..,#####,,,,,,,,,,,,#-H-#,,#B-#,,,",
            ",,,,#---#,,#--#,,,#-----#,,#--#,..,,,,,,,,#+######,..,,,,,,,,,,,,,,,,,,#---#,,#--+,,,",
            ",,,,#---#,,####,,,#-----#,,#--#,..,,,,,,,,+------#,..,,,,,,,,,,,,,,,,,,+---#,,#--#,,,",
            ",,,,#---+,,,,,,,,,#######,,#--#,..,,,,,,,,#--C---#,..,,,,,,,,,,,,,####,#---+,,####,,,",
            ",,,,#####,,,,,,,,,,,,,,,,,,##+#,..,,,,,,,,#------#,..,,,,,,,,####,#H-#,#####,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,########,..,,,####,#--#,#--#,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,..,,,#--#,#B-#,#+##,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,..,,,,,,,,,,,,,,,,,..,,,#--#,+--#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,%%%%,,,,,,,,,%%,,,,,.....................,,,#H-#,####,,,,,,,#######,,,,,,",
            ",,,,,,,,,,,,%,%,%,,,,,,,,%%%%,,,.....................,,,#--#,,,,,,##+#,,#-----#,,,,,,",
            ",,,,,,,,,,,%%%%,%,,,,,,,,,%,%,,,,,,,,,,,,...,,,,,,,,,,,,#--+,,,,,,#--#,,+-----#,,,,,,",
            ",,,,,####,,,%%%%,,,##+#,%%%%%,,,,,,,,,,,,...,,,,,,,,,,,,#--#,,,,,,#H-#,,#--H--#,,,,,,",
            ",,,,,+--#,,,,,,,,,,#H-#,,%%%,,,,,,,####,,...,,,,,,,,,,,,####,,,,,,#--#,,#-----#,,,,,,",
            ",,,,,#H-#,,,,,,,,,,#--#,,,,,,,,,,,,#a-#,,...,,,,,,,,,,,,,,,,,,,,,,#--#,,#-----#,,,,,,",
            ",,,,,#--#,,,,,,,,,,####,,,,,,,,,,,,#--#,,...,,,,######,,#+##,####,####,,#-----#,,,,,,",
            ",,,,,#--#,,,,,,,,,,,,,,,,,,,,,,,,,,#+##,,...,,,,#-H--#,,#--#,#--#,,,,,,,#######,,,,,,",
            ",,,,,####,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,...,,,,+----#,,#--#,#--#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,########,,,~~~,,,,,,,,,,,,,,,...,,,,######,,#H-#,#S-#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,#--H---#,,~~~~~,,,,,,,,,,,,,,...,,,,,,,,,,,,#--#,+--#,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,#------#,,~~~~~,#+#####,,,,,,...,,,,,,,,,,,,#--#,#--#,,#######,,,,,,,,,,,",
            ",,,,,,,,,,,,####+###,,~~~~~,#-----#,,,,,,...,,,,,,,,,,,,#--#,#--#,,+-----#,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,~~~,,#--H--#,,,,,,,.,,,,,,,,,,,,,####,####,,#--H--#,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,#-----#,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,#-----#,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,#######,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,#######,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,####,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,#--#,,,####,,,,,,,######,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,#--#,,,#--#,,,,,,,#-H--#,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,######,,,,,,,,,,,,,,,,,,,.,#H-+,,,#A-#,,,,,,,#----#,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,#-F--#,,,,,,,,,,,,,,,,,,,.,#--#,,,#--#,,,,,,,###+##,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,+----#,,,########,,,,,,,,.,#--#,,,+--#,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,######,,,+------#,,#####,.,####,,,####,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,#------#,,#---+,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,#--H---#,,#-H-#,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,#------#,,#---#,.,######,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,#------#,,#---#,.,#-H--+,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,#------#,,#####,.,#----#,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,########,,,,,,,,.,######,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,",
            ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,"
        };

        foreach (string s in map2)
        {
            System.Console.WriteLine(s);
        }

        while (true)
        {
            cki = System.Console.ReadKey();
            if (cki.KeyChar == 'w') y--;
            if (cki.KeyChar == 'a') x--;
            if (cki.KeyChar == 's') y++;
            if (cki.KeyChar == 'd') x++;
            System.Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                string s1, s2, s3;

                //s1 = map2.(map2[1], 1, 1);

                
            }

            string ps = map[y].Substring(x - 3, 3) + "P" + map[y].Substring(x + 1, 3);

            System.Console.WriteLine(map[y - 3].Substring(x - 3, 7));
            System.Console.WriteLine(map[y - 2].Substring(x - 3, 7));
            System.Console.WriteLine(map[y - 1].Substring(x - 3, 7));
            System.Console.WriteLine(ps);
            System.Console.WriteLine(map[y + 1].Substring(x - 3, 7));
            System.Console.WriteLine(map[y + 2].Substring(x - 3, 7));
            System.Console.WriteLine(map[y + 3].Substring(x - 3, 7));


            System.Console.Write($"X: {x} Y: {y}");
        }
    }
}
