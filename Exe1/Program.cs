Console.Clear();
void CountNumbersArray(int index)
{
    int[] array = new int[index];
    int a = 0;
    for (int i = 0; i < index; i++)
    {
        Console.WriteLine($"Введите число в массив из {index - i} элементов:");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] != 0 && array[i] > 0)
            a++;
    }
    string str = string.Join(" ", array);
    Console.WriteLine(str);
    Console.WriteLine($"Количество чисел введенных больше 0: {a}");
    //return a+1;
}

Console.WriteLine($"Введите колличество элементов иассива (строго больше 0):");
int index = Convert.ToInt32(Console.ReadLine());
if (index > 0)
    CountNumbersArray(index);
else
    Console.WriteLine($"Вы ввели не верное количество чисел в массиве! {index}");