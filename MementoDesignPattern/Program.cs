using System;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new ToyCar();

            var changer = new ColorChanger();

            changer.ChangeColor(car, "Red");

            var savedState = car.SaveState();

            changer.ChangeColor(car, "Blue");
            changer.ChangeColor(car, "Green");

            changer.UndoColorChange(car);

            Console.WriteLine($"Current car color : {car.GetColor()}");

            car.RestoreState(savedState);

            Console.WriteLine($"Restored car color : {car.GetColor()}");




        }
    }
}
