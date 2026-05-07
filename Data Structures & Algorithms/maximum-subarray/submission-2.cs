public class Solution {
    public int MaxSubArray(int[] nums) {
        int atualMaior = nums[0];
        int maiorSoma = nums[0];

        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > nums[i] + atualMaior)            
                atualMaior = nums[i];
            else
                atualMaior = nums[i] + atualMaior;
            if(maiorSoma < atualMaior)
                maiorSoma = atualMaior;
            
        }
        return maiorSoma;
    }
}
