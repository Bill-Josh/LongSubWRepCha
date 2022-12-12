using System;
/*
 * @author Billy Bedon Pacheco
 */

namespace LongestSubstr
{
    class Program : LongSubString
    {
        public static void Main(string[] args)
        {
            //Input Test Strings
            //abcabcbb  Expectation:3
            //bbbbb     Expectation:1
            //pwwkew    Expectation:3
            string message = "abcabcbb";
            Console.WriteLine(message);
            Console.WriteLine($"The max Length of the Longest Substring without repeating characters is: {MaxLength(message)}");
            Console.ReadKey();
        }
    }
}
