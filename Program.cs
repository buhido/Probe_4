// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



bool isWork = true;


while (isWork)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "task25": Task25(); break;
        case "task27": Task27(); break;
        case "task29": Task29(); break;
        case "exit": isWork = false; break;
    }
}
void Task25()
{ //Задача  25   Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
  // Примеры: 3, 5 -> 243 
  //          2, 4 -> 16
    int numberA = ReadInt("Введите число A: ");
    int numberB = ReadInt("Введите число B(степень числа А): ");
    Degree(numberA, numberB);

    void Degree(int A, int B)         // Функция для возведения в степень
    {
        int result = 1;
        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }
        Console.WriteLine("Результат:  " + result);
    }

    int ReadInt(string input)        // Функция для ввода входных чисел
    {
        Console.WriteLine(input);
        return Convert.ToInt32(Console.ReadLine());
    }
}
void Task27()
{ //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
  //452 -> 11
  //82 -> 10
  //9012 -> 12

    int number = ReadInt("Введите число: ");
    int len = NumberLen(number);
    SumNumbers(number, len);

    // Функция ввода
    int ReadInt(string input)
    {
        Console.Write(input);
        return Convert.ToInt32(Console.ReadLine());
    }
        // Функция подсчета цифр в числе
    int NumberLen(int a)
    {
        int index = 0;
        while (a > 0)
        {
            a /= 10;
            index++;
        }
        return index;
    }
       // Функция вывода суммы цифр в числе
    void SumNumbers(int n, int len)
    {
        int sum = 0;
        for (int i = 1; i <= len; i++)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
    }
}
void Task29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    //8 -> [1, 2, 5, 7, 4, 11, 16, 19]


    int lenArray = ReadInt("Введите длину массива: ");

    int[] randomArray = new int[lenArray];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(1, 19);
        Console.Write(randomArray[i] + " ");
    }
        // Функция ввода
    int ReadInt(string input)
    {
        Console.Write(input);
        return Convert.ToInt32(Console.ReadLine());
    }
}

