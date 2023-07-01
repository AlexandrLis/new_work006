// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
int Length (string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int [] FillArray (string message, int M)
{
    System.Console.WriteLine(message);
    int [] array1 = new int [M];
    for (int i = 0; i < M; i++)
    {
        array1[i] = Convert.ToInt32(System.Console.ReadLine());
    }
    return array1;
}
void PrintArray (int [] array)
{
    System.Console.WriteLine("Ваш массив: ");
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int Resultat (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
//-----------------------------------------------------------
int M = Length("Укажите длину массива: ");
int [] arrays = FillArray("Введите элементы массива: ", M);
PrintArray(arrays);
System.Console.WriteLine("Количество элементов массива больше нуля -> " + Resultat(arrays));



//напишите программу, которая найдет точку пересечения двух
//прямых, заданных уравнниями: 
// y = k1*x + b1
// y = k2*x + b2
//значения k1, b1, k2 и b2 задаются пользователем

void Numbers (out int k1, out int b1, out int k2, out int b2)
{
    k1 = 0;
    k2 = 0;
    b1 = 0;
    b2 = 0;
    System.Console.Write("Введите значение K1: ");
    k1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите значение b1: ");
    b1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите значение K2: ");
    k2 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите значение b2: ");
    b2 = Convert.ToInt32(Console.ReadLine());
}

int [] Resultat(int k1, int k2, int b1, int b2)
{
    int [] array = new int [2];
    array[0] = (b2 - b1)/(k1 - k2);
    array[1] = k1*array[0] + b1;
    return array;
}
void PrintArray(int [] arr)
{
    System.Console.WriteLine(string.Join(", ", arr));
}
//-------------------------------------------------------

Numbers(out int k1, out int b1, out int k2, out int b2);
int [] answer = Resultat(k1,b1,k2,b2);
System.Console.Write("Точка пересечения двух прямых -> ");
PrintArray(answer);