//Take an input array and a number of flowers that will be attempted to be planted
// if you can plant the number of requested flowers in the given array return true, else false
// so if the array is only [0] then 1 flower can be planted
// if the array starts with 0,0 or ends with 0,0 then we can add a flower
// if there's 0,0,0 then we can add a flower in the middle

// bool Func PlantTheFlowers(int[] flowerbed. int numberOfFlowers)
//  {
//      int flowerCount = 0;
//      if left value is at the beginning or i -1 and
//      if middle value 0 and
//      if right value is 0 then we can plant
//      for (left, middle and right are 0)
//          {
//             flowerbed[i] = 1;  
//             flowerCount++;                  
//          }
//  if flowerCount == numberOfFlowers then true, else false

bool CanPlaceFlowers(int[] flowerbed, int n)
{
    if (n == 0)// for some reason  n is 0 there's nothing to check
    {
        return true;
    }

    int count = 0;
    int length = flowerbed.Length;

    for (int i = 0; i < length; i++)
    {
        // if this plot is empty and both neighbors (if exist) are empty:
        bool emptyLeft = (i == 0) || flowerbed[i - 1] == 0; //first checks if we're at the beginning of the array before we check i -1
        bool emptySelf = flowerbed[i] == 0; //checks if the current plot is empty
        bool emptyRight = (i == length - 1) || flowerbed[i + 1] == 0; //checks if we're at the end of the array before we check i + 1'

        if (emptyLeft && emptySelf && emptyRight) //if we're empty on the adjacents, we plant
        {
            flowerbed[i] = 1;
            count++;

            if (count >= n)// can we plant at least the same amount of lowers that were requested
            {
                return true;
            }
        }
    }
    return false;
}

int n = 1;
int nn = 2;
int[] flowerbed = { 1, 0, 0, 0, 1 };
int[] flowerbedFalse = { 1, 0, 0, 0, 1 };
int[] flowerbed2 = { 0, 0, 0, 0, 1 };
int[] flowerbed3 = { 0, 0 };
int[] flowerbed3False = { 0, 0 };
int[] flowerbed4 = { 0 };
int[] flowerbed4False = { 0 };
Console.WriteLine($"For garden: [{string.Join(',', flowerbed)}], {(CanPlaceFlowers(flowerbed, n) ? $"you can place {n} flower{(n != 1 ? "s" : "")}" : $"you cannot place {n} flower{(n != 1 ? "s" : "")}")}");
Console.WriteLine($"For garden: [{string.Join(',', flowerbedFalse)}], {(CanPlaceFlowers(flowerbedFalse, nn) ? $"you can place {nn} flower{(nn != 1 ? "s" : "")}" : $"you cannot place {nn} flower{(nn != 1 ? "s" : "")}")}");
Console.WriteLine($"For garden: [{string.Join(',', flowerbed2)}], {(CanPlaceFlowers(flowerbed2, nn) ? $"you can place {nn} flower{(nn != 1 ? "s" : "")}" : $"you cannot place {nn} flower{(nn != 1 ? "s" : "")}")}");
Console.WriteLine($"For garden: [{string.Join(',', flowerbed3)}], {(CanPlaceFlowers(flowerbed3, n) ? $"you can place {n} flower{(n != 1 ? "s" : "")}" : $"you cannot place {n} flower{(n != 1 ? "s" : "")}")}");
Console.WriteLine($"For garden: [{string.Join(',', flowerbed3False)}], {(CanPlaceFlowers(flowerbed3False, nn) ? $"you can place {nn} flower{(nn != 1 ? "s" : "")}" : $"you cannot place {nn} flower{(nn != 1 ? "s" : "")}")}");
Console.WriteLine($"For garden: [{string.Join(',', flowerbed4)}], {(CanPlaceFlowers(flowerbed4, n) ? $"you can place {n} flower{(n != 1 ? "s" : "")}" : $"you cannot place {n} flower{(n != 1 ? "s" : "")}")}");
Console.WriteLine($"For garden: [{string.Join(',', flowerbed4False)}], {(CanPlaceFlowers(flowerbed4False, nn) ? $"you can place {nn} flower{(nn != 1 ? "s" : "")}" : $"you cannot place {nn} flower{(nn != 1 ? "s" : "")}")}");