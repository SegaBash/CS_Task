
int[] city = new int[] { 5, 3, 7, 3, 6, 1, 9, 2, 4, 7, 2, 4, 2, 8, 2, 10, 2 };

int maxValue = GetMaxValue(city);
int waterVolume = GetWaterVolume(city, maxValue);
Console.WriteLine("Объем воды = " + waterVolume);

int GetMaxValue(int[] arr)
{
    int maxValue = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxValue < arr[i]) maxValue = arr[i];
    }
    return maxValue;
}
int GetWaterVolume(int[] arr, int max)
{
    int sumToltal = 0;
    for (int i = 1; i <= maxValue; i++)
    {
        int jStart = 0;
        int jEnd = 0;
        int n = 0;
        int sumLine = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] >= i)
            {
                if (n == 0) jStart = j;
                else jEnd = j;
                n++;
            }
        }
        if (n > 1) sumLine = jEnd - jStart - (n-1) ;
        sumToltal += sumLine;
    }
    return sumToltal;
}