var arr = new int[8];
FillArray(arr);
//Console.WriteLine("[" + String.Join(", ", arr) + "]");
Console.WriteLine(PutArrayToString(arr));


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(1, 10);
}

string PutArrayToString(int[] arr)
{
    string str = "";
    foreach (var val in arr)
    {
        if (str != "") str += ", ";
        str += val;
    }
    return "[" + str + "]";
}