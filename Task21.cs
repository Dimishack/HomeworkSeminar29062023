using System;

namespace HomeworkSeminar29062023
{
    /*
     * Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
     * A (3,6,8); B (2,1,-7), -> 15.84
     * A (7,-5, 0); B (1,-1,9) -> 11.53
     */
    internal class Task21
    {
        internal static void DistanceTwoPoints()
        {
            double differenceBetweenTheCoordinatesToSqr = 0;

            double[] Point(string numberPoint)
            {
                Console.WriteLine("Введите координаты {0} точки:", numberPoint);
                Console.Write("x = ");
                if (!Double.TryParse(Console.ReadLine(), out var x))
                    throw new Exception("Введено неккоректное значение x");
                Console.Write("y = ");
                if (!Double.TryParse(Console.ReadLine(), out var y))
                    throw new Exception("Введено неккоректное значение y");
                Console.Write("z = ");
                if (!Double.TryParse(Console.ReadLine(), out var z))
                    throw new Exception("Введено неккоректное значение z");
                return new double[3] { x, y, z};
            }
            Console.WriteLine("Введите координаты двух точек для нахождения расстояния между ними в пространстве:");
            var pointFirst = Point("первой");
            var pointSecond = Point("второй");
            for (int i = 0; i < pointFirst.Length; i++)
                differenceBetweenTheCoordinatesToSqr += Math.Pow(pointSecond[i] - pointFirst[i], 2);
            var distance = Math.Sqrt(differenceBetweenTheCoordinatesToSqr);
            Console.WriteLine("Расстояние от первой точки с координатами ({0}, {1}, {2}) " +
                                "и второй точки с координатами ({3}, {4}, {5}) = {6}",
                                pointFirst[0], pointFirst[1], pointFirst[2],
                                pointSecond[0], pointSecond[1], pointSecond[2],
                                Math.Round(distance, 2));
        }
    }
}
