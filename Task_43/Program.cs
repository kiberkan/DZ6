// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите кординату первого отрезка по Х: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату первого отрезка по Y: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату второго отрезка по Х: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату второго отрезка по Y: ");
double k2 = Convert.ToDouble(Console.ReadLine());

void Intersection(double k1 ,double b1, double k2 ,double b2)
{
   if ((k1 == k2) && (b1 == b2))
   {
    System.Console.WriteLine("Прямые совпадают, количесво точек пересечения = infinity");
   }
   else if (k1==k2)
   {
    System.Console.WriteLine("Прямые параллельны, они никогда не пересекутся");
   }
   else
   {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    //x = Math.Round(x, 3);
    //y = Math.Round(y, 3);
    Console.Write("Пересечение в точке : (" + String.Format("{0:F1} ", x));
    Console.Write(String.Format("{0:F1}", y) + ")");
   }
}


Intersection(k1,b1,k2,b2);
