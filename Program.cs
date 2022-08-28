// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите первую координату первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());   //a,2
Console.Write("Введите вторую координату первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());   //b,5
Console.Write("Введите первую координату второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());   //c,4
Console.Write("Введите вторую координату второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());   //d,9


double Cross(int a, int b, int c, int d) 
{
return  (c-a)/(b-d);  
}
double Cross1(int a, int b, int c, int d)
{
return  (b*((a-c)/(b-d)))+a;
}
double resultx = Cross(b1,k1,b2,k2);
Console.WriteLine($"{resultx}");
double resulty = Cross1(b1,k1,b2,k2);
Console.WriteLine($"{resulty}");


// x = (b2-b1)/(k1-k2);
// y = (k2*((b1-b2)/(k1-k2)))+b1;


