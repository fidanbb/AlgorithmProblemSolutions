
//Merge Sorted Array problem from LeetCode

void Merge(int[] nums1, int m, int[] nums2, int n)
{

    if (m == 0)
    {
        for (int i = 0; i < n; i++)
            nums1[i] = nums2[i];
    }

    else if (n > 0)
    {
        for (int i = m; i < m + n; i++)
        {
            nums1[i] = nums2[i - m];
        }     
    }

    Array.Sort(nums1);

    //foreach (var item in nums1)
    //{
    //   Console.Write(item);  // to see the output 
    //}

}

//int[] nums1 = { 1, 2, 3 };
//int[] nums2 = { 2, 5, 6 };
//Merge(nums1, 3, nums2, 3);

//int[] nums1 = { 0 };
//int[] nums2 = { 1 };

//Merge(nums1, 0, nums2, 1);

//int[] nums1 = { 1, 2, 3, 0, 0, 0 };
//int[] nums2 = { 2, 5, 6 };

//Merge(nums1, 3, nums2, 3);

//int[] nums1 = { 0 };
//int[] nums2 = { 1 };

//Merge(nums1, 0, nums2, 1);