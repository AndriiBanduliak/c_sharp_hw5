using static System.Console;
Clear();

float[] arr = new float[5];

fillArr(arr);
WriteLine($"[{String.Join(" ", arr)}]-> {nimMaxDiff(arr)}");

void fillArr(float[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
    }
}
float nimMaxDiff(float[] arr)
{
    float min, max;
    max = min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}