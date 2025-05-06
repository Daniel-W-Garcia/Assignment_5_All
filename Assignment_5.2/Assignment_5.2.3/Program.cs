// use recursion to print all natural numbers from  'n' to 1
// method should just decrement and print n
// calls itself until 1 - n is reached
// func void Print (int) 
//  {
//      if n <= 0
//      CW(n)
//      n--
//  }

void PrintIntReversed(int n)
{
    if (n > 0)
    {
        Console.WriteLine(n);
        PrintIntReversed(n - 1);
    }
}

PrintIntReversed(5);
