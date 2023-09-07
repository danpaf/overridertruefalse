using overridertruefalse.Classes;

namespace overridertruefalse
{
    class MyArr
    {
        public int x, y, z;

        public MyArr(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static bool operator true(MyArr i)
        {
            if ((i.x > 0) && (i.y > 0) && (i.z > 0))
                return true;
            return false;
        }

        public static bool operator false(MyArr i)
        {
            if ((i.x <= 0) || (i.y <= 0) || (i.z <= 0))
                return true;
            return false;
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Player Alex = new Player();
            Player Edvard = new Player("Edvard",DateTime.Now, "Eduard");
            Player goodboy2004 = new Player("GoodBoy2004_zxc","qwertyQWERTY",DateTime.Now, "Maxim"); 
            goodboy2004.ShowInfo("qwertyQWERTY");
        }
    }
}