string[] ConvertStringsToArray() // Ввод строк и преобразование в массив
{
    int count = 0;
    string[] array = new string[count];
    string[] temp;
    string s;
    do
    {
        s = Console.ReadLine();
        if (s != "")
        {
            count++;
            temp = new string[count];
            for (int i = 0; i < temp.Length - 1; i++)
            {
                temp[i] = array[i];
            }
            temp[count - 1] = s;
            array = temp;
        }
    } while (s != "");
    return array;
}


void OutputArrayStrings(string[] set) // Вывод массива строк
{
    Console.Write("[");
    for (int i = 0; i < set.Length - 1; i++)
    {
        Console.Write($"{set[i]}, ");
    }
    Console.Write($"{set[set.Length - 1]}]");
    Console.WriteLine();
}


string[] DetermineLengthElementAndFormNewArrayStrings(string[] set) // Определение длины элементов и формирование нового массива строк
{
    int count = 0;
    string[] answer = new string[count];
    string[] temp;
    for (int i = 0; i < set.Length; i++)
    {
        string k = set[i];
        int length = k.Length;
        if (length < 4)
        {
            count++;
            temp = new string[count];
            for (int l = 0; l < temp.Length - 1; l++)
            {
                temp[l] = answer[l];
            }
            temp[count - 1] = k;
            answer = temp;
        }
    }
    return answer;
}

Console.WriteLine("Введите несколько строк длиной до 10 элементов.");
Console.WriteLine("После каждой строки нажмите <Enter>.");
Console.WriteLine("После завершения ввода нажмите <Enter>.");
string[] array = ConvertStringsToArray();
OutputArrayStrings(array);
string[] answer = DetermineLengthElementAndFormNewArrayStrings(array);
OutputArrayStrings(answer);
