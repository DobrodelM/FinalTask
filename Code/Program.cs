int getUserInt(string message)
{
    Console.Write(message);
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
string[] GenerateUserArray(int length)
{
    string[] newArray = new string[length];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i}");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}
void printArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("[]");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine(array[array.Length - 1] + "]");
    }
}
string[] FormNewArray(string[] array, int number)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= number)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}
int size = getUserInt("Введите длину массива: ");
string[] array = GenerateUserArray(size);
printArray(array);
int maxWordLength = getUserInt("Введите максимальную длину строки в символах: ");
string[] newArray = FormNewArray(array, maxWordLength);
printArray(newArray);
