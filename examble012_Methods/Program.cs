//for (int i = 2; i <= 10; i++)
//{
//    for (int j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} x {j} = {i*j}");
//    }
//    Console.WriteLine();
//}


//Console.Clear();
//string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//            + "ежели  бы вас послали вместо нашего милого Винценгероде,"
//            + "вы бы взяли приступом согласие прусского короля. "
//            + "Вы так красноречивы. Вы дадите мне чаю?";

//string Replase(string text, char oldValue, char newValue)
//{
//    string result = String.Empty;
//    int length = text.Length;
//    for (int i = 0; i < length; i++)
//    {
//        if (text[i] == oldValue) result = result + $"{newValue}";
//        else result = result + $"{text[i]}";
//    }

//    return result;
//}
//string newText = Replase(text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replase(newText, 'к', 'К');
//Console.WriteLine(newText);



// не рабочий
Console.Clear();
int[] arr = {1,5,4,3,2,6,7,1,1};
void PrintArray(int[] arrya)
{
    int count = arrya.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arrya[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] arrya)
{
    for (int i = 0; i < arrya.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arrya.Length; j++)
        {
            if (arrya[j] < arrya{minPosition}) 
            {
                minPosition = j;
            }
        }
        int temporary = arrya[i];
        arrya[i] = arrya[minPosition];
        arrya[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);