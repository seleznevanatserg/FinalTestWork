namespace UserMethods;

public class Method
{

    // Метод считывания из строки ввода и преобразования число.
    public static int InputParsedIntNumber()
    {
        bool isParsed = int.TryParse(Console.ReadLine(), out int num);
        if (!isParsed) return 0;
        else return num;
    }

 

    //Метод проверки корректного ввода и исключения 0.
    public static int ChekingNumberForPositive(int number, string msgOfError = "")
    {
        if (number < 1 || number > 9999999)
        {
            Console.WriteLine("Uncorrect number");
            while (number < 1 || number > 9999999)
            {
                Console.WriteLine(msgOfError);
                number = InputParsedIntNumber();
            }
        }
        return number;
    }



    // Метод для формирования исходного однострочного массива строк.
    public static string[] GenerateRandomWords(int num)
    {
        Random random = new Random();
        string[] array = new string[num];
        for (int i = 0; i < array.Length; i++)
        {
            int rnd = random.Next(1, 7);
            array[i] = RandomWord(rnd);
        }
        return array;
    }

    // Метод печати одномерного массива.
    public static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++) Console.Write($"[{i + 1}]{array[i]}  ");
        Console.WriteLine();
    }

    // Метод генерации слова (набора символов) путём выбора случайных элементов строки.
    public static string RandomWord(int rnd, string rndWord = "")
    {
        Random random = new Random();
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        if (rnd > 0) rndWord = rndWord + alphabet[random.Next(0, alphabet.Length)] + RandomWord(rnd - 1);
        return rndWord;
    }



}
