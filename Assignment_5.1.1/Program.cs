int testThisInt = 121;
int testThisInt2 = 123;

bool IsAPalindrome(int inputNumber)
{
    int reversedNumber = 0;
    int originalNumber = inputNumber;
    
    if (inputNumber < 0) //negative numbers are not palindromes
    {
        return false;
    }

    if (inputNumber >= 0 && inputNumber <= 9)//single digit numbers are palindromes modulus 
    {
        return true;
    }

    while (inputNumber > 0) //input nummber will change (drops last digit because of inputNumber/10) each loop until it is 0
    {
        int digit = inputNumber % 10; //get the last digit of the inputNumber each loop (which sheds a digit each loop)
        reversedNumber = reversedNumber * 10 + digit; //this reconstructs the reversed number each loop
        
        inputNumber /= 10; //remove the last digit and set the inputNumber to the new value
    }
    
    
    return originalNumber == reversedNumber;
}

Console.WriteLine($"""
                   the number {testThisInt}
                   {(IsAPalindrome(testThisInt) ? "is" : "is not")} a palindrome
                   the number {testThisInt2}
                   {(IsAPalindrome(testThisInt2) ? "is" : "is not")} a palindrome
                   """);