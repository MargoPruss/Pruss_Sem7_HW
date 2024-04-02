// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


void PrintReverseArray (int[] array, int i)
{
    if(i < 0) return;
    Console.Write($"{array[i]} ");
    PrintReverseArray(array, i - 1);
}

int[] array = {1, 2, 5, 0, 10, 34};

PrintReverseArray(array, array.Length - 1);