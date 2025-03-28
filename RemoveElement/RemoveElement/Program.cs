
// Remove element leet code problem solution
 int RemoveElement(int[] nums, int val)
{
    int count = 0;
    int n = nums.Length;

    for (int i = 0; i < n; i++)
    {
        if (nums[i] != val)
        {
            nums[count] = nums[i];
            count++;
        }
    }
    
    for (int i = 0; i< n-count; i++)
    {
        Console.WriteLine(nums[i]);
    }

    return count;
}

Console.WriteLine(RemoveElement(new int []{3, 2, 2, 3 },3));