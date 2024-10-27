﻿using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] data = GenerateRandomArray(10000);

        // Bubble Sort
        int[] bubbleSortData = (int[])data.Clone();
        Stopwatch stopwatch = Stopwatch.StartNew();
        BubbleSort(bubbleSortData);
        stopwatch.Stop();
        Console.WriteLine($"Bubble Sort Time: {stopwatch.ElapsedMilliseconds} ms");

        // Quick Sort
        int[] quickSortData = (int[])data.Clone();
        stopwatch.Restart();
        QuickSort(quickSortData, 0, quickSortData.Length - 1);
        stopwatch.Stop();
        Console.WriteLine($"Quick Sort Time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 10000);
        }
        return array;
    }

    static void BubbleSort(int[] data)
    {
        for (int i = 0; i < data.Length - 1; i++)
        {
            for (int j = 0; j < data.Length - i - 1; j++)
            {
                if (data[j] > data[j + 1])
                {
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
    }

    static void QuickSort(int[] data, int left, int right)
    {
        int i = left, j = right;
        int pivot = data[(left + right) / 2];
        while (i <= j)
        {
            while (data[i] < pivot) i++;
            while (data[j] > pivot) j--;
            if (i <= j)
            {
                int tmp = data[i];
                data[i] = data[j];
                data[j] = tmp;
                i++;
                j--;
            }
        }
        if (left < j) QuickSort(data, left, j);
        if (i < right) QuickSort(data, i, right);
    }
}
