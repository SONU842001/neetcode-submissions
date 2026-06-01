public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>();
        var len = nums.Length;
        for(int i =0; i< len; i++)
        {
            set.Add(nums[i]);
        }
        if(set.Count < len)
        {
            return true;
        }else{
            return false;
        }

    }
}