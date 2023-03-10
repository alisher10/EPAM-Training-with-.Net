namespace OOPTask
{
    public class Car
    {
        public Chassis chassis { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }

        public int seatsNumber { get; set; }

        public override string ToString()
        {
            return $"Car Technical Characteristics\n" +
                   $" Info about chassis:\n" +
                   $" Wheels number is {chassis.WheelsNumber}\n" +
                   $" Permissible load is {chassis.PermissibleLoad}\n" +
                   $" Chassis number is {chassis.ChassisNumber}\n\n" +
                   $" Info about transmission:\n" +
                   $" Gears number {transmission.NumberOfGears}\n" +
                   $" Manufacturer {transmission.Manufacturer}\n" +
                   $" Type {transmission.Type}\n\n" +
                   $" Info about engine:\n" +
                   $" Power of engine {engine.Power}\n" +
                   $" Volume is {engine.Volume}\n" +
                   $" Type of engine {engine.Type}\n" +
                   $" Serial Number {engine.SerialNumber}\n" +
                   $" Number of seats at Car {seatsNumber}\n\n";
        }
    }
}
