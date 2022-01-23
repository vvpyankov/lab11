using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11zadacha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Equation lineEquation = new Equation();
            try
            {
                Console.WriteLine("Решаем линейное уравнение 0=kx+b ");
                Console.Write("Укажите коэффициент k: ");
                lineEquation.CoefK = Convert.ToDouble(Console.ReadLine());
                Console.Write("Укажите коэффициент b: ");
                lineEquation.CoefB = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода!");
                return;
            }
            lineEquation.Solution();
            Console.ReadKey();
        }
    }
    /*struct Equation
    {
        public double coefK;
        public double VarX { get; set; }
        public double CoefB { get; set; }

        public double CoefK
        {
            set
            {
                if (value != 0)
                {
                    сoefK = value;
                }
                else
                {
                    Console.WriteLine("Коэффициент k не может быть равен 0");
                    Console.ReadKey();
                }
            }
            get
            {
                return coefK;
            }
        }
        public Equation(double VarX,double CoefB, double CoefK, double coefK)
        {
            this.VarX = VarX;
            this.CoefB = CoefB;
            CoefK = сoefK;
        }
        public void Solution()
        {
            double VarX = (-CoefB) / CoefK;
            Console.WriteLine("Решение уравнения. Х = {0:f2}", VarX);
        }
    }*/
    struct Equation
    {
        private double coefK;

        public double CoefK
        {
            get
            {
                return coefK;
            }
            set
            {
                if (value != 0)
                {
                    coefK = value;
                }
                else
                {
                    Console.WriteLine("Коэффициент k не может быть равен 0");
                }
            }
        }

        public double CoefB { get; set; }

        public Equation(double CoefK, double CoefB)
        {
            this.coefK = CoefK;

            this.CoefB = CoefB;
        }

        public void Solution()
        {
            Console.WriteLine("Решение уравнения: Х = {0:f2}", (-CoefB) / CoefK);
        }
    }
}

