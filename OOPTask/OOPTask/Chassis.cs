namespace OOPTask
{
    public class Chassis
    {
        public int WheelsNumber { get; }

        public int PermissibleLoad { get; }

        public string ChassisNumber { get; }

        public Chassis(int wheelsNumber, int permissibleLoad, string chassisNumber) {

            if (WheelsNumber > 0 && PermissibleLoad > 0 && ChassisNumber.Length > 0)
            {
                WheelsNumber = wheelsNumber;
                PermissibleLoad = permissibleLoad;
                ChassisNumber = chassisNumber;
            }
            else {
                WheelsNumber = 0;
                PermissibleLoad = 0;
                ChassisNumber = "SNDEFAULT";
            }
        }
    }
}
