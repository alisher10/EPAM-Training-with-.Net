namespace InterfaceAndAbstractClass
{
    class Bird
    {
        public Coordinate currentPosition = new Coordinate(0, 0, 0);
        public static Random random = new Random();
        public int speed = random.Next(0,15);

        public Bird(Coordinate coordinate)
        {
            currentPosition = coordinate;
        }

        public double FlyTo(Coordinate coordinate)
        {
            double distance = Math.Pow((Math.Pow(coordinate.x - currentPosition.x, 2) +
                         Math.Pow(coordinate.y - currentPosition.y, 2) +
                         Math.Pow(coordinate.z - currentPosition.z, 2) *
                                   1.0), 0.5);
            return distance;
        }

        public double GetFlyTime(Coordinate coordinate)
        {
            return FlyTo(coordinate) / speed;
        }

        public override string ToString()
        {
            return ("Birds position: " + this.currentPosition + " & " + "speed: " + this.speed);
        }
    };

}
