// use recursion to print all natural numbers up to 'n'
// method should just increment and print n
// calls itself until 1 - n is reached
// func void PrintInt (int n, int target) 
//  {
//      if n <= 0
//      CW(n)
//      n--
//  }

void PrintInts(int n)
{
    if (n <= 0)
    {
        return;
    }
    PrintInts(n - 1); //Head recursion to work backwards from n to 1
    Console.WriteLine(n); // PrintInts waiting to print n
                            // PrintInts waiting to print n - 1
                                // PrintInts waiting to print n - 1 -1 ... and so on
                         // now prints n -1 -1 (or last iteration when n was still bigger than 0
                            // now prints n -1
                                //now prints n
}
PrintInts(5);
