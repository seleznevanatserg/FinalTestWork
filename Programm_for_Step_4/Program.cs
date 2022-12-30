/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше или равна 3 символа. */

using static UserMethods.Method;

Random random = new Random();
string msgAmountWords = "Enter number for amount generate words, please. It's number > 0.";
Console.WriteLine(msgAmountWords);
int amountWords = InputParsedIntNumber();
amountWords = ChekingNumberForPositive(amountWords, msgAmountWords);
int count = 0;
string[] wordArray = GenerateRandomWords(amountWords);
Console.WriteLine("The following words were created: [serial_number]<word>");
PrintArray(wordArray);
Console.WriteLine();
string[] newWord3Array = SelectedWordsShort3Symbols(wordArray, out count);
PrintArray(newWord3Array);
MessageResult(count);

// Метод для отбора строк длиной 3 символа и меньше.
string[] SelectedWordsShort3Symbols(string[] array, out int count)
{
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }

    string[] newArray = new string[count];
    if (count != 0)
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[j] = array[i];
                j++;
            }
        }
    }

    return newArray;
}


// Метод сообщений 
// Сообщение о количестве обнаруженных строк длиной 3 символа и меньше.
void MessageResult (int count)
{
    if (count != 0)
    {
    string msgCountWord = "Found the number of words with a length of 3 characters or less: ";
        Console.WriteLine(msgCountWord + count);
    }
    else
    {
        string msgZeroArr = "Sorry, but this array don't have words long 3 symbols and less.";
        Console.WriteLine(msgZeroArr);
    }
}


