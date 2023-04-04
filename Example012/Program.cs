// Вид 1. Ни чего не принимает ни чего не возвращает.

//void Method1()
//{
//    Console.WriteLine("Автор...");
//}
//Method1();

// Вид 2. Что-то принимают ни чего не возвращают.
//void Method2(string msd)
//{
//    Console.WriteLine(msd);
//}

//Method2(msd: "Тeкст сообщения...");

//void Method21(string msd, int count)
//{
//    int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(msd);
//        i++;
//    }
//}
//Method21(msd: "Teкст", count: 4);
//Method21(count: 4, msd: " новый текст");

// Вид 3. Ни чего не принимают, что-то возвращают.

//int Method3()
//{
//    return DateTime.Now.Year;
//} 

//int year = Method3();
//

//Вид 4. Что-то принимает, что то возвращает.

/*int Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "b");
Console.WriteLine(res);
*/

/*int Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0;i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "b");
Console.WriteLine(res);
*/

// Работа с цикламми while u for Использование цикла в цикле)
// 1. Тблица умножения

//for (int i = 2; i <= 10; i++)
//{
//    for (int j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} * {j} = {i*j}");
//    }
//    Console.WriteLine();
//}

//Задача 1. Дан текст в котором нужно все пробелы заментиь черточками, 
//маленькие букв "к" заменить большими "K", а большие "С" заменить маленькими "с".

//string text = " - Я думаю, - сказал князь, улыбаясь, что -"
//            + " ужули бы вас послали вместо нашего милого Винценгероде,"
//            + " вы бы взяли приступом согласие прусского короля. "
//            + " Вы так красноречивы. Вы дадите мне чаю?";

 //string s = "qwerty"     
//             012345
// s[3]// r

/*string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int Length = text.Length;
    for (int i = 0; i < Length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

String newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'K');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'С', 'с');
Console.WriteLine(newText);
*/

//Задача 2. Работа с массивами
// 68321457 поменять местами рабочий элемент максимальный и минимальный (12345678)

/*int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
     Console.WriteLine();
} 

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/

