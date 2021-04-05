using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLaba02
{
    sealed class abstractnaslednic : teorya
    {
        public override void teorya1()
        {
            Console.WriteLine("абстрактный класс готов и наследник тоже и дальше наследоваться нельзя");

        }

        public override void teorya_1()
        {
            Console.WriteLine("Привет2!");
        }
    }
}
