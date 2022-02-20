using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasFourWheels { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"Vroom vroom");
        }
    }
}
