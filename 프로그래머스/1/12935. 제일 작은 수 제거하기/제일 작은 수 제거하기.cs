using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length == 1)
        {
            arr[0] = -1;
            return arr;
        }
        int temp = arr[0];
        for(int i =0; i <arr.Length; i++)
        {
            if(temp > arr[i])
            {
                temp = arr[i];
            }
        }
        List<int> list = new List<int>();
        list.AddRange(arr);
        list.Remove(temp);
        
        int[] answer = new int[] {};
        answer = list.ToArray();
        return answer;
    }
}