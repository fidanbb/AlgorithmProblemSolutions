
static int RemoveDuplicates(int[] nums)
{
    if (nums == null) return 0;
    if (nums.Length <= 2) return nums.Length;

    int k = 2;

    for (int i = 2; i< nums.Length; i++)
    {
        if (nums[i] != nums[k-2])
        {
            nums[k] = nums[i];
            k++;
        }
    }

    return k;
}

Console.WriteLine(RemoveDuplicates(new int[] { 1, 1, 1, 2, 2, 3 }));
Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }));