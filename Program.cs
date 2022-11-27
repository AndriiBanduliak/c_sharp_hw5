using static System.Console;
Clear();

int[] arr = new int[4];
fillArr(arr);
WriteLine($"[{String.Join(",", arr)}]-> {oddSum(arr)}");

void fillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 51);
    }
}
int oddSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) sum += arr[i];
    }
    return sum;
}