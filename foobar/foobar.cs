namespace foobar;

public class Algorithm
{
    public int y;
    public int x;

    public static void CheckNumber(int x, int y)
    {
        for (int i = x; i <= y; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write($"foobar, ");
            }
            else if (i % 3 == 0)
            {
                Console.Write($"foo, ");
            }
            else if (i % 5 == 0)
            {
                Console.Write($"bar, ");
            }
            else
            {
                Console.Write($"{i}, ");
            }
        }
    }
}