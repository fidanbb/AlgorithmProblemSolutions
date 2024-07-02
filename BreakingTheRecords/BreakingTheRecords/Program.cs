//Maria plays college basketball and wants to go pro. Each season she maintains
//    a record of her play. She tabulates the number of times she breaks her season
//    record for most points and least points in a game. Points scored in the first 
//    game establish her record for the season,
//    and she begins counting from there.


 static List<int> breakingRecords(List<int> scores)
{
    List<int> result = new List<int>();

    int min = scores[0];
    int max = scores[0];
    int min_break = 0;
    int max_break = 0;  

foreach (var item in scores)
    {
        if (item > max)
        {
            max = item;
            max_break++;
        }

        if (item < min)
        {
            min = item;
            min_break++;
        }
    }

    result.Add(max_break);
    result.Add(min_break);

    return result;
}

foreach (var item in breakingRecords(new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 }))
{
    Console.WriteLine(item);
}


