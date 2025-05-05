//take an int array and count the number of times each number appears
//if any int appears more than once in the array, return true

//create a dictionary to store the number as the key and the count as the value
// bool AreThereDupes(takes an int array)
//  {
//      iterate through the array
//      if the number is already in the dictionary, increment the count
//      if the number is not in the dictionary, add it to the dictionary with a count of 1
//      go through the key values pairs in the dictionary until you find a value of 2 or more
//      return true or false based on if there are any values of 2 or more
//  }


int[] arrayToCount = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; 
int[] arrayToCount2 = {1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10};
Dictionary<int, int> countDictionary = new Dictionary<int, int>();

bool AreThereDuplicates(int[] arrayOfInts)
{
    foreach (int number in arrayOfInts)
    {
        if (countDictionary.ContainsKey(number))
        {
            countDictionary[number]++;
        }
        else
        {
            countDictionary.Add(number, 1);
        }
    }
    
    foreach (KeyValuePair<int, int> pair in countDictionary)
    {
        if (pair.Value > 1)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine($"""
                   For the array: {string.Join(", ", arrayToCount)} 
                   {(AreThereDuplicates(arrayToCount) ? "There are duplicates" : "There are no duplicates")}
                   For the array: {string.Join(", ", arrayToCount2)}
                   {(AreThereDuplicates(arrayToCount2) ? "There are duplicates" : "There are no duplicates")}
                   """);



