//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Write number of the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

    void CheckingTheDayOfTheWeek (int day) {
    if (day < 1 || day > 7) {
        Console.WriteLine("there is no such day of the week. Write again.");
    }
        else 
            if (day == 6 || day == 7)  {
            Console.WriteLine("it's a day off -> да");
  }
   
        else 
            Console.WriteLine("it's not a day off -> нет");
    }
CheckingTheDayOfTheWeek(day);