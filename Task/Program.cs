// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
Console.Write("Введите размер массива: ");
int mas_size = Convert.ToInt32(Console.ReadLine());
string [] mass = new string [mas_size];
for (int i = 0; i < mas_size; i++)
{
    Console.Write("Введите "+ (i+1) + " элемент масиива: ");
    string element = Convert.ToString(Console.ReadLine());
    mass[i] = element;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(mass);