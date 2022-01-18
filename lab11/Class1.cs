using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class Cat
        
    {public const int countFeet = 4;
        public readonly bool = true;
        public string Name { get; set; }
        public string Color { get; set; }
        int age;

        public int Age
        {
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст не м.б. отрицательным");
                }
            }
            get
            {
                return age;
            }
        }
        public Cat(string name, string color, int age, bool wool)
        {
            Name = name;
            Color = color;
            Age = age;
            this.wool = wool;
        }
        public void Say()
        {
            Console.WriteLine("Мяу! Меня зовут {0}. У меня {1} цвет! Мне {2} лет!", Name, Color, Age);
        }

    }
}
