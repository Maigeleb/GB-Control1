// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам

Console.WriteLine("Enter string array:");
string[] inputArray = GetArray(Console.ReadLine());

Console.WriteLine("Entered array:");
for (int i = 0; i < inputArray.Length; i++)
{
    Console.WriteLine(i + ": " + inputArray[i]);
}
Console.WriteLine();

string[] outputArray = WorkWithArray(inputArray);

Console.WriteLine("Output Array:");
for (int i = 0; i < outputArray.Length; i++)
{
    Console.WriteLine(i + ": " + outputArray[i]);
}

string[] GetArray(string input) => input.Split(' ');

string[] WorkWithArray(string[] input)
{
    string[] res = Array.Empty<string>();
    int counter = 1;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length < 4)
        {
            Array.Resize(ref res, counter);
            res[counter - 1] = inputArray[i];
            counter++;
        }
    }
    return res;
}