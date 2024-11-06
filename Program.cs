namespace Poke_e_main;

class Program
{
    static void Main(string[] args)
    {
        SceneManager sceneManager = new SceneManager();

        int mapRadius = 7;
        int x = 70, y = 70;

        sceneManager.LoadScene(Maps.GetMainMap(), x, y);
    }
}
