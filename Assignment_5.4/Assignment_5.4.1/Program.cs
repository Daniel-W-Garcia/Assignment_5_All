//Use recursion to parse out individual digits from a number.
// will use % 10 to get last digit then use / 10 to drop last digit and repeat.

//int[] ParseDigits(int number)
//  {
//
//      digit = number % 10;
//      number = number / 10;
//  }
//      int[] = ParseDigits(number);
//

int[] ParseDigits(int number)
{
    if (number == 0)//Base case so we can exit recursion
    {
        return [];//return empty array
    }
    int digit = number % 10; //get last digit
    
    int[] digits = ParseDigits(number / 10); //create array of digits by calling function recursively and dropping last digit
                                                    //Each recursive call goes deeper until the base case is reached;
                                                    //only **after** the base case does the array begin to be put together on the way back up.

                                                    // the digit is held until the array is created when number == 0
                                                    // digits are added to the array in the order they were parsed
    return digits.Concat(new int[] { digit }).ToArray(); //add all digits to array and return an array

}
int first = 12345;
int second = 98765;
Console.WriteLine($"The number {first} is parsed into: {string.Join(", ", ParseDigits(first))}");
Console.WriteLine($"The number {second} is parsed into: {string.Join(", ", ParseDigits(second))}");