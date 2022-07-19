using System;
//Task#1
// Given an integer x, return true if x is palindrome integer.

// An integer is a palindrome when it reads the same backward as forward.

// For example, 121 is a palindrome while 123 is not.
 

// Example 1:

// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.
// Example 2:

// Input: x = -121
// Output: false
// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
// Example 3:

// Input: x = 10
// Output: false
// Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }

  public bool IsPalindrome(int x)
  {
       
  }

//Task 2

  // Given an array, return indices of the array that match the target
// You can assume that only one solution exists

// [1,9,2,19]  Target = 3, Answer = 0,2
// [2,4]  Target = 6, Answer =0,1
  public int [] GetMatchingTargetIndices(int [] nums, int target)
  {
      int[] answer={};
       int[] input=nums;
      int arraylenght=input.Length;
      int count=0;
      while(arraylenght > 0)
      {
      for(int i=1;i < input.Length;i++){
        if(input[count]+input[i]==target)
        {
          answer.SetValue(count,0);
          answer.SetValue(i,1);

           return answer;
        }
       
        count +=1;
      }
      }
      return answer;
  }
}