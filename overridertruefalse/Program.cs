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

    class Program{
        static void Main(string[] args)
        {
            MyArr arr1 = new MyArr(4, 5, 12);
            MyArr arr2 = new MyArr(4, 5, 12);
            if (arr1 == arr2)
            {
                Console.WriteLine("Объекты равны");
            }
            MyArr arr3 = new MyArr(4, 6, 12);
            MyArr arr4 = new MyArr(4, 5, 12);
            if (arr3 == arr4)
            {
                Console.WriteLine("Объекты равны");
            }
            else
            {
                Console.WriteLine("Объекты не равны");
            }

            if (arr1)
            {
                Console.WriteLine("Элементы объекта положительны");
            }
        }
    }
}