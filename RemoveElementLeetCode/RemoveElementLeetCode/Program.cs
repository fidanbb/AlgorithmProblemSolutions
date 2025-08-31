
// remove element form array problem in leetcode


int RemoveElement(int[] nums, int val)
{

    int k = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[k] = nums[i];
            k++;
        } 
    }

    return k;
}


Console.WriteLine(RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
