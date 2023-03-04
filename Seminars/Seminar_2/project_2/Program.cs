// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6





  Console.Write("Write Number: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
if (b.Length > 2){
  Console.WriteLine("three digit -> " + b[2]);
}
else {
  Console.WriteLine("-> no third digit");
}