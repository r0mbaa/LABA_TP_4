using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class TrafficCop : Policeman
    {
        override
            public void sayHello()
        {
            Console.WriteLine($"Добрый день! Я служу в ГАИ! Меня зовут - {FirstName + " " + LastName}");
        }

        override
           public void takeMoney()
        {
            Console.WriteLine($"- Возьмите, это вам , {FirstName}! \n- Спасибо за деньги! ");
        }
    }

}
