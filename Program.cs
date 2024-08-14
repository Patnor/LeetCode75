namespace LeetCode75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 605. Can Place Flowers
            // int[] flowerbed = {1,0,0,0,1,1,0,0,0,1,1,1,1,1};
            // int[] flowerbed = {1,0,0,0,0,0,1};
            // int [] flowerbed = {1,0,1,0,1,0,1};
            // int[] flowerbed = { 1, 0, 0, 0, 1, 0, 0 };
            int[] flowerbed = { 0, 0, 1, 0, 1 };
            int n = 1;
            Console.WriteLine("flowers: " + canPlaceFlowers(flowerbed, n));
        }

        public static bool canPlaceFlowers(int[] flowerbed, int n)
        {

            if (n == 0)
            {
                return true;
            }

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0)
                        && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    n--;
                    if (n == 0)
                        return true;
                }
            }

            return false;
        }
    }
}
