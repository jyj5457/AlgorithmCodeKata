using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int onecount=0;
        int zerocount=0;
        int convertcount=0;
        while(s.Length!=1)
        {
            char[] temp = s.ToCharArray();
            for(int i=0; i<temp.Length; i++)
            {
                if(temp[i]=='1')
                {
                    onecount++;
                }
                else if(temp[i]=='0')
                {
                    zerocount++;
                }
            }
            string bin = Convert.ToString(onecount,2);
            convertcount++;
            s= bin;
            onecount =0;
        }
        int[] answer = new int[]{convertcount,zerocount};
        return answer;
    }
}