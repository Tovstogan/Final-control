/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.*/

Console.Clear();
Console.WriteLine("Итоговая работа");

string[] M;
            Console.WriteLine("Введите массив строк через пробел");
            string stroka = Console.ReadLine();
            M = stroka.Split(' ');

void PrintSecondArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string buffer = array[i];
        if (buffer.Length <= 3)
            Console.Write($"{array[i]} ");
    }
}
string[] array = M;
Console.WriteLine("Массив из трех символов: ");
PrintSecondArray(array);