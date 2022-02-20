using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasTwoWheels { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"Zooooommm");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"Zooooommm");
        }
    }
}
