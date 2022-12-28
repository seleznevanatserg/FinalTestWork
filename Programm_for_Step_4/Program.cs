/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше или равна 3 символа. */

string [] wordArray = {"12","22","Yes","NO","Array"};
PrintArray(wordArray);

string [] newWord3Array = SelectedWordsShort3Symbols(wordArray);
PrintArray(newWord3Array);

// Метод для отбора строк длиной 3 символа и меньше.
string [] SelectedWordsShort3Symbols(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        count++;
    }

    string [] newArray = new string [count];
    if (count == 0) MessageForZeroArray();
    else 
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i].Length <= 3) 
            {
                newArray[j] = array[i];
                j++;
            }
        }        
    }

    return newArray;
}
// Метод печати одномерного массива.
void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"[{i}]{array[i]}  ");
    Console.WriteLine();
}
// Метод сообщения о нулевом массиве в случае если не обнаружено строк длиной 3 символа и меньше.
void MessageForZeroArray()
{
    string msgZeroArr = "Sorry, but this array don't have words long 3 symbols and less.";
    Console.WriteLine(msgZeroArr);
}