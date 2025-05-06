
// return the length of the last word in a string
// trim the string to remove leading and trailing spaces
// iterate over a string looking for ' ' char
// count the chars that follow the ' ' char
// do not count punctuation

// int CountCharacters
// int sum
//  {
//      for i = end of string and continue backwards to the first ' ' char
//          if we hit space count the chars and place the value in sum
//  return sum
//  }



int sum = 0;
string inputString = "Hello World";
inputString = inputString.Trim();


for (int i = inputString.Length - 1; i >= 0; i--)
{
    if (inputString[i] == ' ')
    {
        break;
    }

    if (char.IsLetter(inputString[i]))
    {
        sum++;
    }
}
Console.WriteLine(sum);