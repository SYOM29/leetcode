// Time: O(n)
// Space: O(1)
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(n == 0) return;
        
        var nums1P = m - 1;
        var nums2P = n - 1;
        var swapP = m + n - 1;
        
        while(nums1P >= 0 || nums2P >= 0)
        {
            if(nums1P == -1 || (nums2P >= 0 && nums1[nums1P] < nums2[nums2P]))
            {
                Swap(nums1, swapP, nums2, nums2P);
                swapP--;
                nums2P--;
            }
            else
            {
                Swap(nums1, swapP, nums1, nums1P);
                swapP--;
                nums1P--;
            }
        }
    }
    
    public void Swap(int[] nums1, int p1, int[] nums2, int p2)
    {
        nums1[p1] = nums2[p2];
    }
}