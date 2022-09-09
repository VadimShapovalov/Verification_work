void CreateNewArray(string[] array)
{
    int newSize = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) newSize++;
    }
    string[] newArray = new string[newSize];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    for (int i = 0; i < newArray.Length; i++) Console.Write(newArray[i] + "  ");
}
string[] array = new string[] { "hello", "hi", "mama", "pi", "rich", "42", "1221" };
CreateNewArray(array);