using static System.Console;
Clear();

int[] arr = new int[4];

fillArr(arr);
WriteLine($"[{String.Join(",", arr)}]-> {evenCount(arr)}");

void fillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}
int evenCount(int[] arr)
{
    int counter = 0;
    foreach (int i in arr)
        if (i % 2 == 0) counter++;
    return counter;
}