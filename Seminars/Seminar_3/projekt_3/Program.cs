//Задача 23: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Write namber: ");
int root = Convert.ToInt32(Console.ReadLine());

void Cube(int[] root){
  int counter = 0;
  int length = root.Length;
  while (counter <  length){
    root[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] cube = new int[root+1];
Cube(cube);
PrintArry(cube);