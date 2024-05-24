

//void fizzBuzz(int n)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        if (i % 3 == 0 && i % 5 == 0)
//        {
//            Console.WriteLine("FizzBuzz");
//        }
//        if (i % 3 == 0 && i%5!=0 )
//        {
//            Console.WriteLine("Fizz");
//        }
//        if (i % 5 == 0 && i % 3 != 0)
//        {
//            Console.WriteLine("Buzz");
//        }
//        if (i % 3 != 0 && i % 5 != 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

//fizzBuzz(15);


//Subteam team = new Subteam("team", 2);

//Console.WriteLine(team.teamName);
//Console.WriteLine(team.AddPlayer(3));
//Console.WriteLine(team.RemovePlayer(4));
//Console.WriteLine(team.ChangeTeamName("newTeam"));
//public class Team
//{
//    public string teamName;

//    public int noOfPlayers;

//    public Team(string teamName, int noOfPlayers)
//    {
//        this.teamName = teamName;
//        this.noOfPlayers = noOfPlayers; 
//    }

//    public int AddPlayer(int count)
//    {
//        noOfPlayers=noOfPlayers+count;
//        return noOfPlayers;
//    }

//    public bool RemovePlayer(int count)
//    {
//        if(noOfPlayers - count<0)
//        {
//            return false;
//        }

//        noOfPlayers = noOfPlayers - count;
//       return true;
//    }
//}

//public class Subteam : Team
//{
//    public Subteam(string teamName, int noOfPlayers):base(teamName,noOfPlayers) { }


//    public string ChangeTeamName(string name)
//    {
//        this.teamName=name;

//        return name;
//    }
//}



// static List<int> compareTriplets(List<int> a, List<int> b)
//{
//    int scoreA = 0;
//    int scoreB = 0;

//    for (int i = 0; i < a.Count; i++)
//    {
//        if (a[i] > b[i])
//        {
//            scoreA++;
//        }
//        if (a[i] < b[i])
//        {
//            scoreB++;
//        }
//    }

//    List<int> result = new List<int>();

//    result.Add(scoreA);
//    result.Add(scoreB);

//    return result;

//}

//List<int> a = new List<int>() { 17, 28, 39 };
//List<int> b = new List<int>() { 99, 16, 8 };

//List<int> result = compareTriplets(a, b);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//using System.Text.Json;



//int result = await Result.getWinnerTotalGoals("UEFA Champions League", 2011);

//Console.WriteLine(result);

//public class AllCompetitions
//{
//    public int page { get; set; }

//    public int per_page { get; set; }

//    public int total { get; set; }

//    public int total_pages { get; set; }

//    public AllCompetitionsData[] data { get; set; }
//}

//public class AllCompetitionsData
//{
//    public string name { get; set; }

//    public string country { get; set; }

//    public int year { get; set; }

//    public string winner { get; set; }

//    public string runnerup { get; set; }
//}

//public class Matches
//{
//    public int page { get; set; }

//    public int per_page { get; set; }

//    public int total { get; set; }

//    public int total_pages { get; set; }

//    public Competition[] data { get; set; }
//}

//public class Competition
//{
//    public string competition { get; set; }

//    public int year { get; set; }

//    public string round { get; set; }

//    public string team1 { get; set; }

//    public string team2 { get; set; }

//    public string team1goals { get; set; }

//    public string team2goals { get; set; }
//}


//public class Result
//{
//    public static async Task<int> getWinnerTotalGoals(string competition, int year)
//    {
//        HttpClient client = new HttpClient();

//        var totalGoals = 0;

//        var currentPage = 1;

//        var totalPages = 1;

//        var winner = "";


//        // 1. Get who won the competition?
//        while (currentPage <= totalPages)
//        {

//            // Get API data.
//            var apiResult = await client.GetStreamAsync(
//                $"https://jsonmock.hackerrank.com/api/football_competitions?year={year}&name={competition}&page={currentPage}"
//            );

//            // Deserialise into AllCompetitions class.
//            var result = await JsonSerializer.DeserializeAsync<AllCompetitions>(apiResult);

//            // If on first page, update total pages.
//            if (currentPage == 1)
//            {
//                totalPages = result.total_pages;
//            }

//            // Get the competition winner?
//            winner = result.data.FirstOrDefault().winner;

//            // Check next page results.
//            currentPage++;
//        }


//        // -------------------------------


//        // Reset pagination.
//        currentPage = 1;

//        totalPages = 1;

//        // 2. Get their home goals for that competition?
//        while (currentPage <= totalPages)
//        {

//            // Get API data.
//            var apiResult = await client.GetStreamAsync(
//                $"https://jsonmock.hackerrank.com/api/football_matches?competition={competition}&year={year}&team1={winner}&page={currentPage}"
//            );

//            // Deserialise into Matches class.
//            var result = await JsonSerializer.DeserializeAsync<Matches>(apiResult);

//            // If on first page, update total pages.
//            if (currentPage == 1)
//            {
//                totalPages = result.total_pages;
//            }

//            // Append home team goals.
//            totalGoals += result.data.Sum(x => Int32.Parse(x.team1goals));

//            // Check next page results.
//            currentPage++;
//        }


//        // -------------------------------


//        // Reset pagination.
//        currentPage = 1;

//        totalPages = 1;

//        // 3. Get their visiting goals for that competition?
//        while (currentPage <= totalPages)
//        {

//            // Get API data.
//            var apiResult = await client.GetStreamAsync(
//                $"https://jsonmock.hackerrank.com/api/football_matches?competition={competition}&year={year}&team2={winner}&page={currentPage}"
//            );

//            // Deserialise into Matches class.
//            var result = await JsonSerializer.DeserializeAsync<Matches>(apiResult);

//            // If on first page, update total pages.
//            if (currentPage == 1)
//            {
//                totalPages = result.total_pages;
//            }

//            // Append visiting team goals.
//            totalGoals += result.data.Sum(x => Int32.Parse(x.team2goals));

//            // Check next page results.
//            currentPage++;
//        }

//        return totalGoals;
//    }

//}




// static int diagonalDifference(List<List<int>> arr)
//{
//    int dif = 0;
//    int sum1 = 0;
//    int sum2 = 0;
//    for (int i = 0; i < arr.Count; i++)
//    {
//        for (int j = 0; j < arr[i].Count; j++)
//        {
//            if (i==j)
//            {
//                sum1 += arr[i][j];
//            }
//            if (i + j == arr[i].Count-1)
//            {
//                sum2 += arr[i][j];
//            }
//        }
//    }

//    dif=Math.Abs(sum1-sum2);

//    return dif;
//}

//int n = Convert.ToInt32(Console.ReadLine().Trim());

//List<List<int>> arr = new List<List<int>>();

//for (int i = 0; i < n; i++)
//{
//    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//}

//int result = diagonalDifference(arr);

//Console.WriteLine(  result);

