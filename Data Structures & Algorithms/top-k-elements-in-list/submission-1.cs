public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int,int>();
        for(int i=0;i< nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }else
            {
                map[nums[i]] =1;
            }
        }
        return map
        .OrderByDescending(pair => pair.Value)
        .Take(k)
        .Select(pair => pair.Key)
        .ToArray();

    }
}
