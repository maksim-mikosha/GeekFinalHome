Console.WriteLine("Введите массив из чисел, разделяя элементы запятыми");
Console.Write("Ввод массива - ");
string userString = Console.ReadLine();
string[] userArray = new string[CalcArrayLength(userString)];

ParseStringToArray(userString);
WriteArray(userArray);

int CalcArrayLength(string userString)
{
    int countArrayLength = 0;
    for (int i = 0; i < userString.Length; i++)
    {
        string tempString = string.Empty;
        while (userString[i].ToString() != ",")
        {
            tempString += userString[i];
            i++;
            if (i == userString.Length)
            {
                break;
            }
        }

        if (tempString.Length <= 3)
        {
            countArrayLength++;
        }
    }
    return countArrayLength;
}

void ParseStringToArray(string userString)
{
    int count = 0;

    for (int i = 0; i < userString.Length; i++)
    {
        string tempString = string.Empty;
        while (userString[i].ToString() != ",")
        {
            tempString += userString[i];
            i++;
            if (i == userString.Length)
            {
                break;
            }
        }

        if (tempString.Length <= 3)
        {
            userArray[count] = tempString;
            count++;
        }
    }
}

void WriteArray(string[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"{userArray[i]} ");
    }
}