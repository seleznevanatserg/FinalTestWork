# Итоговая проверочная работа

## Описание работы

1. Создание репозитория на GitHub
2. Создание блок-схемы алгоритма
3. Оформление файла README.md
4. Написание программы с использованием языка C#
5. Демонстрация знаний по использованию контроля версий

## 1. Создание репозитория на GitHub

Данный репозиторий был создан на ПК, а после загружен на GitHub в качестве задачи для итоговой проверочной работы.

Название репозитория ***FinalTestWork***.

Ссылка на Github https://github.com/seleznevanatserg/FinalTestWork.git

Репозиторий снабжён файлами README.md (информация о репозитории) и .gitignore (список игнорируемых для коммитов файлов и директорий).

## 2. Создание блок-схемы алгоритма

Блок-схема программы (главного метода) для итоговой проверочной работы была создана в сервисе Drow.io и представленна отдельным файлом.

Ссылка на Drive.Google https://drive.google.com/file/d/1jDF4flOng1I9DosTWGIqHw_Cbk2738L1/view?usp=sharing

## 3. Оформление файла README.md

К репозиторию с программой приложен файл README.md, содержащий в себе описание основных этапов работы над контрольным итоговым заданием и алгоритм работы программы.

## 4. Написание программы с использованием языка C#

*Данный раздел содержит этапы работы программы и их описание*

### **Ввод данных**

Ввод данных начинается с сообщения, приглашающего пользователя указать количество слов (наборов символов) для генерации.

Метод считывания данных из строки и преобразования их в число:

    int InputParsedIntNumber()

а на выходе выдаст введённое значение или вернёт 0. На ввод значения стоит ограничение, не дающее пользователю ввести что-то, кроме значения числа больше 0 и меньше 10,000,000. Это проверяется другим методом - проверка положительного значения. 

    int ChekingNumberForPositive(int number, string msgOfError = "")

Соответственно, если пользователь ввёл что-то, не являющееся числом, или число вне диапазона, алгоритм программы заставит пользователя заного ввести значение. И так до тех пор, пока пользователь введёт значение, удовлетворяющее условиям выхода.

*string msgOfError = ""*  -- переменная для настраиваемого сообщения о причине ошибки ввода. 

 ### **Обработка данных**

Обработка данных производится следующим образом:

Получив от пользователя число, программа вызывает метод генерации одномерного массива строк, длина которого равна введёному числу (количество слов).

    string[] GenerateRandomWords(int num)

В свою очередь этот метод создаёт внутри себя случайную величину *lenghtWord* от 1 до 6, которую передаёт в вызываемый метод генерации слова (набора символов) в качестве длины этого слова.

    string RandomWord(int lenghtWord, string rndWord = "")

Метод генерации слов работает рекурсивыным образом, с каждой итерацией прибавляя символ к концу начального значению строки. Символы выбираются случайным образом из строки алфавита (36 символов: буквы латиницы от A до Z и цифры от 0 до 9). Ограничением рекурсии стоит переменная длины слова. 
    
На выходе получается строка, которая возвращается в метод генерации исходного массива *GenerateRandomWords* для присвоения i-тому элементу массива. В конце метод возвращает одномерный массив строк.

Получив сгенерированный одномерный массив строк, программа отправит его в метод отбора слов с длиной 3 символа и менее.

    string[] SelectedWordsShort3Symbols(string[] array, out int count)

Предварительно метод переберёт массив в поиске слов (наборов символов) с длиной 3 символа и менее и посчитает их количество.
    
Далее метод создаст новый массив, куда запишет слова (наборы символов) с длиной 3 символа и менее. Длина этого массива равна количеству слов с длиной 3 символа и менее, для чего их и считали. Данная конструкция имет место быть в связи с ограничением (рекомендацией) не использовать коллекции.

Если по каким бы то нибыло причинам слов с длиной 3 символа и менее обнаружено не будет, то программа вернёт массив с нулевой длиной.

Из метода *SelectedWordsShort3Symbols* возвращается новый одномерный массив строк, содержащий слова длиной 3 символа и менее и через **out** возврашается значение *count*, содержашее в себе количество слов с длиной 3 символа и менее.

### **Вывод данных**

Программа выводит на печать исходный массив со всеми словами и массив со словами с длиной 3 символа и менее. В обоих случаях используется метод

    void PrintArray(string[] array)

Также программа выводит сообщения о результатах обработки массива и об ошибках ввода пользователя.
Для этого есть метод сообщений

    void MessageResult (int count)

В зависимости от результата *count* выводит сообщения о найденных или ненайденных словах длиной 3 символа и менее.

## 5. Демонстрация знаний по использованию контроля версий

Для этого в репозиторий добавлялись поэтапно компоненты итоговой проверочной работы и фиксировались каждый одтельными коммитами.