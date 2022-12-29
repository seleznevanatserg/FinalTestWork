/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше или равна 3 символа. */

Random random = new Random();

MessageForAmountWords();
int amountWords = InputParsedIntNumber();
amountWords = ChekingNumberForPositive(amountWords);

string[] wordArray = GenerateRandomWords(amountWords);
Console.WriteLine("The following words were created: [serial_number]<word>");
PrintArray(wordArray);

string[] newWord3Array = SelectedWordsShort3Symbols(wordArray);
PrintArray(newWord3Array);

// Метод для отбора строк длиной 3 символа и меньше.
string[] SelectedWordsShort3Symbols(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }

    string[] newArray = new string[count];
    if (count == 0) MessageForZeroArray();
    else
    {
        MessageForCount3SymbleWord(count);
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

// Метод печати одномерного массива.
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"[{i + 1}]{array[i]}  ");
    Console.WriteLine();
}

// Метод для формирования исходного однострочного массива строк.
string[] GenerateRandomWords(int num)
{
    string[] array = new string[num];
    for (int i = 0; i < array.Length; i++)
    {
        int rnd = random.Next(1, 7);
        array[i] = RandomWord(rnd);
    }
    return array;
}

// Метод генерации слова (набора символов) путём выбора случайных элементов строки.
string RandomWord(int rnd, string rndWord = "")
{
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    if (rnd > 0) rndWord = rndWord + alphabet[random.Next(0, alphabet.Length)] + RandomWord(rnd - 1);
    return rndWord;
}

// Метод считывания из строки ввода и преобразования число.
int InputParsedIntNumber()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (!isParsed) return 0;
    else return num;
}

//Метод проверки корректного ввода и исключения 0.
int ChekingNumberForPositive(int number)
{
    if (number < 1)
    {
        Console.WriteLine("Uncorrect number");
        while (number < 1)
        {
            MessageForAmountWords();
            number = InputParsedIntNumber();
        }
    }
    return number;
}

// Методы сообщений 
// Сообщение о количестве обнаруженных строк длиной 3 символа и меньше.
void MessageForCount3SymbleWord(int count)
{
    string msgCountWord = "Found the number of words with a length of 3 characters or less: ";
    Console.WriteLine(msgCountWord + count);
}
// Сообщение о нулевом массиве в случае если не обнаружено строк длиной 3 символа и меньше.
void MessageForZeroArray()
{
    string msgZeroArr = "Sorry, but this array don't have words long 3 symbols and less.";
    Console.WriteLine(msgZeroArr);
}
// Сообщение с предложением ввода количества генерируемых слов (наборов символов).
void MessageForAmountWords()
{
    string msgAmountWords = "Enter number for amount generate words, please. It's number > 0.";
    Console.WriteLine(msgAmountWords);
}