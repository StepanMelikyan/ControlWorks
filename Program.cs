
Console.WriteLine("введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());

//создание первого массива
string[] array1 = new string[n];  
int i = -1;

//заполнение первого массива
while (i < n -1)
{
    Console.WriteLine("введите элемент массива");
    array1[i + 1] = Console.ReadLine();
    i++;
}

//печать первого массива
void PrintArray1 (string [] arr) 
{
    Console.Write("Массив номер 1: ");
    for (int j = 0; j < array1.Length; j++)
    {
    Console.Write($"'{array1[j]}', ");
    }
}
PrintArray1(array1);

//определение длины второго массива
int lenght = 0;
for (int e = 0; e < array1.Length; e++)
{
    if ( array1[e].Length < 4)
    {
        lenght++;
    }
}
Console.WriteLine(); //пустая строка для разделения массивов

//создание второго массива
string[] array2 = new string[lenght]; 

//заполнение второго массива
int f = 0;
for (int k = 0; k < array1.Length; k++) 
{
    if ( array1[k].Length < 4)
    {
        array2[f] = array1[k];
        f++;
        lenght++;
    }
}

//печать второго массива
void PrintArray2 (string [] arr) 
{
    Console.Write("Массив номер 2: ");
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"'{array2[i]}', ");
    }
}

PrintArray2(array2);


