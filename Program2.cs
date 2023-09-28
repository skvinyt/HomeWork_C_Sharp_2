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
Console.Clear();
Console.WriteLine ("Введите номер дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine ());
if (day == 6 || day == 7) {
    Console.WriteLine (day + " - это выходной");
} else {
    Console.WriteLine (day + " - это будний день");
} 

