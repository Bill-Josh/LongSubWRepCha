using System;
using System.Collections.Generic;

namespace LongestSubstr
{
    internal class LongSubString
    {
        public static int MaxLength(string msg)
        {
            //Variable
            int maxLength = 0;
            int start = 0;
            int end = 0;
            HashSet<char> sbStrHashSet = new HashSet<char>();

            //While Loop to get SubString Max Length
            while (end < msg.Length)
            {
                if (!sbStrHashSet.Contains(msg[end]))   //If it doesn't contains the parameter in the HashSet then adds it.
                {
                    sbStrHashSet.Add(msg[end]);
                    end++;
                    maxLength = Math.Max(sbStrHashSet.Count, maxLength);
                }
                else    //If the parameter already exists then it removes it from the HashSet. 
                {
                    sbStrHashSet.Remove(msg[start]);
                    start++;
                }
            }

            return maxLength;   //Returns the Max Length from the SubString 
        }
    }
}