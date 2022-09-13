//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
System.Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();

int[] mas = new int[numberStr.Length];

GetArray(numberStr);
Console.WriteLine(GetSum(mas));

int[] GetArray(string numberStr)
{

    for (int i = 0; i < numberStr.Length; i++)
    {
        mas[i] = int.Parse(numberStr[i].ToString());
    }
    return mas;
}

int GetSum(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        sum += mas[i];
    }
    return sum;
}
