﻿int[] array = {1,12,31,18,4,15,16,17,18,92};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}