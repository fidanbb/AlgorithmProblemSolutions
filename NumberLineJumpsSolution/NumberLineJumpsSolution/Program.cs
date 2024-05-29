
#region Solution1
//static string kangaroo(int x1, int v1, int x2, int v2)
//{
//    if (v1 == v2)
//    {
//        return x1 == x2 ? "YES" : "NO";
//    }

//    if ((x2 - x1) % (v1 - v2) == 0 && (x2 - x1) / (v1 - v2) >= 0)
//    {
//        return "YES";
//    }
//    else
//    {
//        return "NO";
//    }
//}
#endregion


#region Solution2
static string kangaroo(int x1, int v1, int x2, int v2)
{
    int firstKangroo=x1+ v1;
    int secondKangroo=x2+ v2;

    if ((x1 < x2 && v1 <= v2) || (x1 > x2 && v1 >= v2))
    {
        return "NO";
    }

    while(firstKangroo != secondKangroo)
    {
        firstKangroo=firstKangroo+v1;
        secondKangroo= secondKangroo+v2;

        if ((firstKangroo > secondKangroo && v1 >= v2) || (secondKangroo > firstKangroo && v2 >= v1))
        {
            return "NO";
        }
    }

    return "YES";
}
#endregion


Console.WriteLine(kangaroo(0,3,4,2));
Console.WriteLine(kangaroo(0,2,5,3));