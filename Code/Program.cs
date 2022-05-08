string [] array = new string [5] {"Звезда", "Дом","Кот","33","Небо"};

string [] newArray = new string [array.Length];

void Viborka( string[]array1, string[]massive)
{
    int count = 0;
    for ( int i=0;i < array1.Length; i ++)
    {
        if (array1[i].Length <=3)
        {
           massive[count] = array1[i];
           count ++;
        }
    }
}

void PrintArray (string[]array2)
{
    for ( int i =0;i < array2.Length;i++)
    {
       Console.WriteLine ( $"{array2[i]}");
       
    }
}
Viborka(array,newArray);
PrintArray(newArray);
