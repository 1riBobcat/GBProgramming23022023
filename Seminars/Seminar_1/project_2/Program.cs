//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 
//(Сравнить с каждым)

//2 3 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


int max = 0;

Console.Write("First Number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Second Number: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Third Number: ");
int third = Convert.ToInt32(Console.ReadLine());

if(first > max)
{
    max = first;
}
if(second > max)
{
    max = second;
}
if(third > max)
{
    max = third;
}

Console.WriteLine("max = " + max);
