﻿using BuilderSample.Builder;
using BuilderSample.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cheap Volkswagen:");
            CarFactoryBase constructor = new CheapCarFactory(new VolkswagenBuilder());
            var car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Luxury Volkswagen:");
            constructor = new LuxuryCarFactory(new VolkswagenBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Cheap Audi:");
            constructor = new CheapCarFactory(new AudiBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Luxury Audi:");
            constructor = new LuxuryCarFactory(new AudiBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            Console.ReadLine();
        }
    }
}
