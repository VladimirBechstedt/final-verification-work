string[] arr = {"hello", "-2", "init", ":-)"};

int designate(string[] arr)
{
    int a = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) a++;
    }   
    return a; 
}

string[] arr_final = new string[designate(arr)];

void selection(string[] arr_final)
{
    int j = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) 
        {
            arr_final[j] = arr[i];
            j++;
        }
    }
}

void PrintArr(string[] value)
{
    Console.Write("Отсортированный массив: ");
    for (int i = 0; i < value.Length; i++)
    {
        Console.Write(value[i]+ " ");
    }
    Console.WriteLine();
}

selection(arr_final);
PrintArr(arr_final);