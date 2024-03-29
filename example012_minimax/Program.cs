﻿// сортировка массива от мин к макс. и наоборот от макс к мин

int[] arr = {1,5,4,3,2,6,7,1,1};

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
    for (int i=0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for(int j = i+1; j <array.Length; j++)
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

void SelectionSort1(int[] array)
{
    for (int i=0; i < array.Length-1; i++)
    {
        int maxPosition = i;
        for(int j = i+1; j <array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
SelectionSort1(arr);

PrintArray(arr);