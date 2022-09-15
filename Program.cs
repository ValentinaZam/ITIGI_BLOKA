string[] mas;

mas = new string[] {"new", "star", "superstar", ":D"};

void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1) Console.Write(array[i]);
        else Console.Write(array[i] + "; ");
    }
    Console.Write("]");
}

string[] CreateNewMass(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }

    string[] arr = new string[size];

    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[k] = array[i];
            k++;
        }
    }
    return arr;
}

ShowArray(mas);
Console.Write("->");
string[] mas2 = CreateNewMass(mas);
ShowArray(mas2);