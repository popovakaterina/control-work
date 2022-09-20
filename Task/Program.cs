// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
Console.Clear(); 
Console.Write("Введите размер массива: ");
int mass_size = Convert.ToInt32(Console.ReadLine());
string [] mass = new string [mass_size];
for (int i = 0; i < mass_size; i++) // Заполнение массива с клавиатуры
{
    Console.Write("Введите "+ (i+1) + " элемент масиива: ");
    string element = Convert.ToString(Console.ReadLine());
    mass[i] = element;
}

string [] new_mass = new string [mass_size]; // массив для финального решения
int position = 0;

for (int j = 0; j < mass_size; j++)
{
    if (mass[j].Length <= 3)
    {
        new_mass[position]= mass[j];
        position++;
    }
}


void PrintArray(string[] array) // Вывод (печать) массива
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


Console.Write("Исходный массив: ");
PrintArray(mass);
Console.Write("Финальный массив: ");
PrintArray(new_mass);