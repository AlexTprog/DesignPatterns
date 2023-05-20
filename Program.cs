using System.Data.Common;
using System;
using DesignPatterns.BuilderPattern;
using DesignPatterns.BuilderPattern.CasePizza;
using DesignPatterns.SingletonPatter;

namespace DesignPatterns // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Builder
            Builder();

            //Pizza builder
            BuilderPizza();

            //Singleton
            SingletonCn();

            //Observer

        }

        public static void Builder()
        {
            var builder = new BuilderEn();
            var director = new Director(builder);
            director.Asc();
        }

        public static void BuilderPizza()
        {
            var kitchen = new Kitchen();
            var size = "family";
            var hawaiana = new HawaianaBuilder(size);

            kitchen.ReceiveNextPizza(hawaiana);
            kitchen.CookPizzaStepByStep();

            var pizza = kitchen.PreparePizza;

            Console.WriteLine(pizza);
        }

        public static void SingletonCn(){
            var dbconection = DatabaseConnection.GetDBConnection();
            dbconection.OpenCn();
            dbconection.CloseCn();
        }
    }
}