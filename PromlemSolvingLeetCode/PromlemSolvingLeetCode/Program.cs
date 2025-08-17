
#region Merge Sorted Array LeetCode

//first one is my aprouch which 

void Merge(int[] nums1, int m, int[] nums2, int n)
{

    //for (int i = m; i < m + n; i++)
    //{
    //    int temp = nums2[i-m];

    //    nums1[i] = temp ; 
    //}

    //Array.Sort(nums1);  //or sort algorithm here but it will increase O(n)

    //for (int i = 0; i < nums1.Length; i++)
    //{
    //    Console.WriteLine(nums1[i]);
    //}



    //this is the way i copied from ai and which make sense it is good to be able to
    //learn other efficient ways of solving problems



    int p1 = m - 1; // Pointer for the last valid element in nums1
    int p2 = n - 1; // Pointer for the last element in nums2
    int pMerge = m + n - 1; // Pointer for the last position in nums1 where elements are merged

    // Merge from the end
    while (p2 >= 0)
    { // Continue as long as there are elements in nums2 to merge
        if (p1 >= 0 && nums1[p1] > nums2[p2])
        {
            // If nums1 has elements and the current element in nums1 is greater
            nums1[pMerge] = nums1[p1];
            p1--; // Move nums1 pointer left
        }
        else
        {
            // Otherwise, take the element from nums2 (or if nums1 is exhausted)
            nums1[pMerge] = nums2[p2];
            p2--; // Move nums2 pointer left
        }
        pMerge--; // Move merge pointer left
    }

    for (int i = 0; i < nums1.Length; i++)
    {
        Console.WriteLine(nums1[i]);
    }
}


int m = 3;
int n = 3;


int[] nums1 = { 1, 2, 3 , 0, 0, 0};

int[] nums2 = { 2, 5, 6 };


Merge(nums1, m , nums2, n);

#endregion


