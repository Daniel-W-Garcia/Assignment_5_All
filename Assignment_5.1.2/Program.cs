//take a number, get it's last digit with %10 then drop last number and repeat

// store inital input number as the remainder
// store sum as 0

//  while remainder > 0
//  { 
//      reminder % 10 = lastDigit
//      sum = lastdigit + lastdigit from previous iteration
//      then divide remainder / 10 for next iteration
// }

int firstNumber = 123;
int secondNumber = 456;

int SumOfAnInteger(int number)
{
    int sum = 0;
    int remainder = number;

    while (remainder > 0)
    {
        int lastDigit = remainder % 10;
        sum += lastDigit;
        remainder /= 10;
    }
    
    return sum;
}

Console.WriteLine($"""
                  The sum of {firstNumber} is {SumOfAnInteger(firstNumber)}
                  The sum of {secondNumber} is {SumOfAnInteger(secondNumber)}
                  """);
        