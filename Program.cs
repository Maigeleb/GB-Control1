// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам

Console.WriteLine("Enter string array:");
string[] inputArray = GetArray(Console.ReadLine());

Console.WriteLine("Entered array:");
for (int i = 0; i < inputArray.Length; i++)
{
    Console.WriteLine(inputArray[i]);
}

string[] GetArray(string input)
{
    string[] res = input.Split(' ');

    return res;
}
