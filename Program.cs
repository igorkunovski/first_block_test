
string[] inserted = Collect_Words();
PrintArray(Short_Words(inserted));


string[] Collect_Words()
{
    string[] all_words = new string[10]; // Array length to change if more than 10 strings 
    int counter = 0;

    do
    {
        Console.Write("Insert string:  ");
        string word = Console.ReadLine();
        if (word != string.Empty)
        {
            all_words[counter] = word;
            counter++;
            continue;
        }
        else
        {
            break;
        }
    } while (true);
    return all_words.Take(counter).ToArray();
}


string[] Short_Words(string[] array)
{
    int counter = 0;

    foreach (string item in array)
    {
        if (item.Length < 4) counter++;
    }
    string[] result = new string[counter];
    counter = 0;

    foreach (string item in array)
    {
        if (item.Length < 4)
        {
            result[counter] = item;
            counter++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    string arrNum = string.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            arrNum += array[i] + ", ";
        }
        else
        {
            arrNum += array[i];
        }
    }
    Console.WriteLine("[" + arrNum + "]");
}
