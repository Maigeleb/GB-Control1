// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам

string[] exampleArray = {"What", "do", "you", "people", "want", "from", "me?"};
string[] inputArray;

Console.WriteLine("Program launch. Use example array? Y / N");
bool useExample = GetInfo();

bool GetInfo()
{
    string res = Console.ReadLine();
    bool check = res == "Y" || res == "N";
    while (!check)
    {        
        Console.WriteLine($"entered: {res}, {check}");
        Console.WriteLine("Incorrect input. Enter Y / N");
        res = Console.ReadLine();
        check = res == "Y" || res == "N";
    }
    return res == "Y";
}

if (useExample)
{
    inputArray = exampleArray;
}
else
{

    Console.WriteLine("Enter string array:");
    inputArray = GetArray(Console.ReadLine());
}




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