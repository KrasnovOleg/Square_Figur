using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Figure
{
    public class Shapes
    {
        public  double Circle(double x)//Площадь круга
        {
            double Square = x * 3.14;

            Console.Write("Периметр круга = ");
            Console.WriteLine(Square);
            return Square;
        }
        public  double box(double x, double y)//Площадь Квадрата и прямоугольника
        {
            if (x == y)
            {
                double Square = x * y;

                Console.Write("Периметр квадрата = ");
                Console.WriteLine(Square);
                return Square;
            }
            else
            {
                double Square = x * y;

                Console.Write("Периметр Прямоугольника = ");
                Console.WriteLine(Square);
                return Square;
            }

        }

        public  double Triangle(double x, double y, double z)//Площадь Треугольника
        {
            double s=0, p;


            if (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2)
            || Math.Pow(y, 2) + Math.Pow(z, 2) == Math.Pow(x, 2)
            || Math.Pow(z, 2) + Math.Pow(x, 2) == Math.Pow(y, 2))
            {
                Console.WriteLine("Это Прямоугольный треугольник!");
                p = (x + y + z) / 2;
                s = (float)Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                Console.Write("Периметр треугольника = " );
                Console.WriteLine(s);
               
            }
            else if (x + y <= z || x + z <= y || y + z <= x)
            {
                Console.WriteLine("Это не треугольник!");
                return 0;
            }
            else if (x == y && y == z)
            {
                Console.WriteLine("Это равносторонний треугольник!");
                p = (x + y + z) / 2;
               double s1 = (float)Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                 s = Math.Round(s1, 3);

                Console.Write("Периметр треугольника = ");
                Console.WriteLine(s);
               
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("Это равнобедренный треугольник!");
                p = (x + y + z) / 2;
                s = (float)Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                Console.Write("Периметр треугольника = ");
                Console.WriteLine(s);
                
            }
            else
            {
                Console.WriteLine("Это треугольник.");
                p = (x + y + z) / 2;
                s = (float)Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                Console.Write("Периметр треугольника = ");
                Console.WriteLine(s);
               
            }
            return s;
        }


        public  double Figure(double x=0, double y=0, double z=0)//Площадь нужной фигуры
        {
            // x = 0, y = 0, z = 0;
            double s = 0;
            if (x != 0 && y == 0 && z == 0)
            {
                Circle(x);
                s= Circle(x);
            }
            else if (x != 0 && y != 0 && z == 0)
            {
                box(x, y);
                s = box(x, y);

            }
            else if (x != 0 && y != 0 && z != 0)
            {
                Triangle(x, y, z);
                s = Triangle(x, y, z);

            }
            else
            {
                Console.WriteLine("Этой формулы нет ");
                
            }
            return s;
        }


        //Не особо понял про лёгкость добавления других фигур, но надеюсь это про разделение формул, что я сделал
    }
}
