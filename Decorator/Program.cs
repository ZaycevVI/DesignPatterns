﻿using DecoratorSample.Beverage;
using DecoratorSample.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase espresso = new Espresso();
            BeverageBase blackTea = new BlackTea();
            BeverageBase greenTea = new GreenTea();

            PrintBeverage(espresso);
            PrintBeverage(blackTea);
            PrintBeverage(greenTea);

            Console.WriteLine("-----------");

            BeverageBase capuccino = new SugarCondiment(new MilkCondiment(new Espresso()));
            PrintBeverage(capuccino);

            BeverageBase greenTeaWithSugar = new SugarCondiment(new GreenTea());
            PrintBeverage(greenTeaWithSugar);

            Console.ReadLine();
        }

        static void PrintBeverage(BeverageBase beverage)
        {
            Console.WriteLine("Beverage: {0}; Price: {1}",
                beverage.GetDescription(), beverage.GetCost());
        }
    }
}
