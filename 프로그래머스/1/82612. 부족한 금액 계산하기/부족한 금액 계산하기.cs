using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long temp = 0;
        for(var i = 1; i <= count; i++)
        {
            temp += i * price;
        }
        if(temp > money)
            {
                return temp - money;
            }
        return 0;
    }
}