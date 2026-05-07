public class Solution {
    public bool hasDuplicate(int[] nums) {
        var visto = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(visto.Contains(nums[i]))
                return true;
            
            visto.Add(nums[i]);
        }
        return false;
    }
}