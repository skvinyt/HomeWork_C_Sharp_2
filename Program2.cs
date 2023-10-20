//Задача 10
// Console.Clear();
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine()); 
// Console.Write(N % 100 / 10);

//Задача 13
// Console.Clear();
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write(N % 10);
// if (N < 10) {
//     Console.Write("Третьей цифры нет");
// }

//Задача 15
// Console.Clear();
// Console.WriteLine ("Введите номер дня недели от 1 до 7: ");
// int day = Convert.ToInt32(Console.ReadLine ());
// if (day == 6 || day == 7) {
//     Console.WriteLine (day + " - это выходной");
// } else {
//     Console.WriteLine (day + " - это будний день");
// } 

//Задача 25
// Console.Clear();
// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 1;
// if (b < 1) {
//     Console.Write("Число B должно быть натуральным");
// } else {
//     while (b!=0) {
//         c = c * a;
//         b = b - 1;
//     }
//     Console.Write("Число A в натуральной степени B равно " + c);
// }

//Задача 27
// Console.Clear();
// Console.Write("Введите число n: ");
// var n = Convert.ToInt32(Console.ReadLine());
// var sum = 0;
// while(n > 0) {
//     sum += n % 10;
//     n /= 10;
// }
// Console.WriteLine("Сумма цифр числа равна: " + sum);

//Задача 29 
// Console.Clear();
// Console.Write("Введите длину массива: ");
// var len = int.Parse(Console.ReadLine());
// var array = new int[len];
// for (int i = 0; i < array.Length; i++) {
//     Console.Write($"array[{i}]=");
//     array[i] = int.Parse(Console.ReadLine());
// }
// for (int i = 0; i < array.Length; i++) {
//     Console.Write($"{array[i]} ");
// }
// Console.ReadKey(true);

//Задача 64
// Console.Clear();
// Console.Write("Введите число N: "); 
// int N = Convert.ToInt32(Console.ReadLine()); 

// for (int i = N; i >= 1; i--) { 
//     Console.Write(i + " "); 
// } 

//Задача 66
// Console.Clear();
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// void SumFromMToN(int m, int n) {
//     Console.Write(SumMN(m - 1, n));
// }

// int SumMN(int m, int n) {
//     int res = m;
//     if (m == n)
//         return 0;
//     else {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }

//Задача 68
Console.Clear();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}