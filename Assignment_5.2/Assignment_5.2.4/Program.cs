// check if a sting is a palindrome using recusrion
// use 2 pointers and work towards the center and compare break out if there's not a match
// retrurn bool 

//  int left = 0
//  int right = string.Length - 1
//
// bool isPalindrome (input string) //have to hide more fields here for this to work
//  {
//      while left < right keep iterating
//          {
//              if string[left] != string[right] return false
//              left++
//              right--
//          }
//      return true


bool IsPalindrome(string inputString, int left = 0, int right = -1) //initialize left pointer to the beginning of the string
{
    //initialize right pointer to the end of the string
    if (right == -1)
    {
        right = inputString.Length - 1;
    }
        
    // if we make it to the middle, it's a palindrome'
    if (left >= right)
    {
        return true;
    }
        
    // If characters don't match, it's not a palindrome
    if (inputString[left] != inputString[right])
    {
        return false;
    }
        
    // move both pointers toward the center
    return IsPalindrome(inputString, left + 1, right - 1);
}
Console.WriteLine(IsPalindrome("racecar")? "This is a palindrome" : "This is not a palindrome");