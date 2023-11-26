// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам

string[] exampleArray = {"What", "do", "you", "people", "want", "from", "me?"};
string[] inputArray;
string[] outputArray;

Work();

void Work()
{
    Console.WriteLine("Program launch. Use example array? Y / N");
    bool useExample = GetBool();

    inputArray = useExample ? exampleArray : GetArray();

    Console.WriteLine();
    ShowArray(inputArray, "Input array");

    outputArray = WorkWithArray();

    ShowArray(outputArray, "Output array");
}

bool GetBool()
{
    string res = Console.ReadLine();
    bool check = res == "Y" || res == "N";
    while (!check)
    {
        Console.WriteLine("Incorrect input. Enter Y / N");
        res = Console.ReadLine();
        check = res == "Y" || res == "N";
    }
    return res == "Y";
}

void ShowArray(string[] array, string name)
{
    Console.WriteLine($"{name}:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i}: {array[i]}");
    }
    Console.WriteLine();
}

string[] GetArray()
{
    string[] res= Array.Empty<string>();
    int counter = 1;

    bool finish = false;
    while (!finish)
    {
        Console.WriteLine();
        Console.WriteLine($"Enter string element #{counter - 1}");
        Array.Resize(ref res, counter);
        res[counter - 1] = Console.ReadLine();
        counter++;

        Console.WriteLine("Do you finish? Enter Y / N");
        finish = GetBool();
    }    
    return res;
}

string[] WorkWithArray()
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