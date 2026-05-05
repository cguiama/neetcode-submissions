public class Solution {
    public int MaxProfit(int[] prices) {
        int minValue = prices[0];
        int maxLucro = 0;
       
        for(int i = 0; i < prices.Length; i++)
        {
            if(minValue > prices[i])
                minValue = prices[i];
            if(prices[i] - minValue > maxLucro)
                maxLucro = prices[i] - minValue;
        }
        return maxLucro;
    }
}
