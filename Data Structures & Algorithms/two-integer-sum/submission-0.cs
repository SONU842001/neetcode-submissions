public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int,int>();
        int[] ans = new int[2];

        for(int i =0;i < nums.Length;i++)
        {
            int rem = target - nums[i];
            if(map.ContainsKey(rem))
            {
                ans[0] = map[rem];
                ans[1] = i;
                break;
            }
            map.Add(nums[i],i);
        }
        return ans;
    }
}
