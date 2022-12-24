namespace InterfaceAndAbstractClass
{
    class Drone : IFlyable
    {
        public Coordinate currentPosition = new Coordinate(0, 0, 0);
        public int speed = 50;

        public Drone(Coordinate coordinate)
        {
            currentPosition = coordinate;
        }
        public double FlyTo(Coordinate coordinate)
        {
            double allowedDistance = Math.Pow((Math.Pow(coordinate.x - currentPosition.x, 2) +
                         Math.Pow(coordinate.y - currentPosition.y, 2) +
                         Math.Pow(coordinate.z - currentPosition.z, 2) *
                                   1.0), 0.5);
            if (allowedDistance < 1000)
            {
                return allowedDistance;
            }
            else {
                return 0;
            }
        }
       
        public double GetFlyTime(Coordinate coordinate)
        {
            return FlyTo(coordinate) / speed * 1.1;
        }

        public override string ToString()
        {
            return ("Drones position: " + this.currentPosition + " & " + "speed: " + this.speed);
        }
    };
}
