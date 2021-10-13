using System;
using System.Collections.Generic;
using Shevtsova;
namespace ShevtsovaLab1
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 3 параметра a, b и с");

                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());

                ShevtsovaLog.I().log("Введенное уравнение: " + a + "x^2" + "+" + b + "x" + "+" + c + "=0");

                Square urav = new Square();
                List<float> arr = urav.Solve(a, b, c);
                ShevtsovaLog.I().log("Корни уравнения: " + string.Join(" ; ", arr));
            }
            catch (ShevtsovaException ex)
            {
                ShevtsovaLog.I().log(ex.Message);
            }
            ShevtsovaLog.I().write();
            Console.ReadKey();
        }
    }
}
