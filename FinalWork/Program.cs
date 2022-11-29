
void CheckingTheLength(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            array1[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("Words and numbers less than or equal to 3: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] array = new string[5] {"Peach", "-3", "School", "you", "I"};
string[] array1 = new string[array.Length];
CheckingTheLength(array, array1);
PrintArray(array1);