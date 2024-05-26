

//You are in charge of the cake for a child's birthday.
//You have decided the cake will have one candle for each
//year of their total age. They will only be able to blow
//out the tallest of the candles. Count how many candles are tallest.
//Example
//    candles = [4,1,2,4]
//The maximum height candles are 4 units high. There are 2 of them, so return 2.


#region Solution1
static int birthdayCakeCandles(List<int> candles)
{
    int max = candles[0];

    int countOfMax = 0;

    foreach (int candle in candles)
    {
        if (candle > max)
        {
            max = candle;
            countOfMax = 1;
        }

        else if (candle==max){
            countOfMax++;
        }
    }


    return countOfMax;
}
#endregion

#region Solution2
//static int birthdayCakeCandles(List<int> candles)
//{
//    return candles.Where(x => x == candles.Max()).Count();
//}
#endregion


Console.WriteLine(birthdayCakeCandles(new List<int> { 4,4, 2, 4, 3 }));