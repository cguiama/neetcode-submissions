public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int i = 0;
        List<int> numbers = new List<int>();
        
        while(i < nums.Length)
        {
            int j = i+1;
            while(j < nums.Length)
            {
                if(nums[i] + nums[j] == target)
                {
                    numbers.Add(i);
                    numbers.Add(j);
                }
                j++;
            }
            i++;
        }
        return numbers.ToArray();
    }
}
