// Determine all the ways to climb a staircase of n steps.
// can take 1 or 2 steps at a time.
// this problem follows the fibonacci sequence so we can use that solution.
//
// int Func Stairs(int n)
//  {
//      return 0 if (n <= 0), 1 if (n == 1), 2 if (n == 2) so we can start at 3rd step in the fibonacci sequence
//      ints for a, b, and c to swap values for each iteration
//          total steps (c) = number of ways to reach step 2 (a) + number of ways to reach step 1 (b);
//          a = b; shufle so 2nd number becomes 1st number;
//          b = total step (c); shuffle the sum of the last 2 numbers to the 2nd number and go again;
int ClimbStairs(int n) // this is a fibonacci sequence solution
{
    // Handle base cases
    if (n <= 0) return 0;
    if (n == 1) return 1;
    if (n == 2) return 2;
    
    // Initialize variables to track ways for previous steps
    int oneStepBefore = 2;  // ways to reach step 2
    int twoStepsBefore = 1; // ways to reach step 1
    int currentWays = 0;
    
    // Calculate ways for each step from 3 to n
    for (int i = 3; i <= n; i++)
    {
        // Ways to reach current step = ways to reach previous step + ways to reach 2 steps back
        currentWays = oneStepBefore + twoStepsBefore; //temp = a + b
        
        // Update values for next iteration
        twoStepsBefore = oneStepBefore; // a = b shuffle so 2nd number becomes 1st number
        oneStepBefore = currentWays; // b = temp shuffle the sum of the last 2 numbers to the 2nd number and go again
    }
    /*for (int i = 2; i <= n; i++) this is the fibonacci sequence solution which we're using above
    {
        temp = a + b;
        a = b;
        b = temp;
    }*/

    
    return currentWays;
}
Console.WriteLine($"To reach 2 stairs there are {ClimbStairs(2)} ways you can get there");
Console.WriteLine($"To reach 3 stairs there are {ClimbStairs(3)} ways you can get there");
Console.WriteLine($"To reach 4 stairs there are {ClimbStairs(4)} ways you can get there");
Console.WriteLine($"To reach 5 stairs there are {ClimbStairs(5)} ways you can get there");
Console.WriteLine($"To reach 6 stairs there are {ClimbStairs(6)} ways you can get there");