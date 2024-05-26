
static List<int> gradingStudents(List<int> grades)
{


    for (int i = 0; i < grades.Count; i++)
    {
        int nextMultiple = (((grades[i] / 5) + 1) * 5);

        if ((nextMultiple - grades[i] < 3) && grades[i] >= 38)
        {
            grades[i] = nextMultiple;
        }

    }

    return grades;
}

foreach (var item in gradingStudents(new List<int> { 73, 67, 40, 33 }))
{
    Console.WriteLine(item);
}

