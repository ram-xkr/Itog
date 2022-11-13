using static System.Console;
Write("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
string[] array = GetArray(size);
WriteLine($"[{String.Join(",", array)}]");
string[] newArray = GetNewArray(array);
WriteLine($"[{String.Join(",", newArray)}]");

string[] GetArray (int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Write("Введите значение эл-та массива: ");
        result[i] = ReadLine()!;
    }
    return result;
}

string[] GetNewArray (string[] Array)
{
    Random rnd = new Random();
    int count = rnd.Next(1, 3+1);

    string[] result = new string[count];
    for (int i = 0; i < count; i++)
    {
        int element = rnd.Next(0, Array.Length);
        result[i] = Array[element];
    }
    return result;
}