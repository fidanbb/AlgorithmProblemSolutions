

//Given a time in 12 -hour AM/PM format, convert it to military (24-hour) time.

//Note: -12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
//- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

//Example

//    s='12:01:00PM'.

//Return '12:01:00'.

//    s='12:01:00AM'.

//Return '00:01:00'.


#region Solution1
//static string timeConversion(string s)
//{
//    DateTime date = DateTime.Parse(s);

//    return date.ToString("HH:mm:ss");
//}
#endregion

#region Solution2
static string timeConversion(string s)
{
    string period = s.Substring(s.Length - 2); 
    string[] timeParts = s.Substring(0, s.Length - 2).Split(':');

    int hours = int.Parse(timeParts[0]);
    string minutes = timeParts[1];
    string seconds = timeParts[2];

    if (period == "AM")
    {
        if (hours == 12)
        {
            hours = 0; 
        }
       
    }
    else 
    {
        if (hours != 12)
        {
            hours += 12; 
        }
    }

    string twentyFourHours = hours.ToString("D2");

    
    return $"{twentyFourHours}:{minutes}:{seconds}";

}
#endregion


Console.WriteLine(timeConversion("07:05:45PM"));
