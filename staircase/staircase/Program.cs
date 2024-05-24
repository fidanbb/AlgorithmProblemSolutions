

#region Solutuion 1
//static void staircase(int n)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        for (int j = 0; j <= n - i; j++)
//        {
//            Console.Write("  ");
//        }
//        Console.WriteLine();

//        for (int k = 0; k < i; k++)
//        {
//            Console.Write("#");
//        }

//    }
//}
#endregion


#region Solutuion 2
static void staircase(int n)
{
    for (int y = n-1; y >= 0; y--)
    {
        for (int x = 0; x < n ; x++)
        {
            if (x>=y)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();

       

    }
}
#endregion

staircase(6);