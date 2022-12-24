namespace InterfaceAndAbstractClass
{
    class Airplane : IFlyable
    {
        public Coordinate currentPosition = new Coordinate(0, 0, 0);
        public int speed = 200;
        public int acceleration = 10;

        public Airplane(Coordinate coordinate)
        {
            currentPosition = coordinate;
        }
        public double FlyTo(Coordinate coordinate)
        {
            double distance =  Math.Pow((Math.Pow(coordinate.x - currentPosition.x, 2) +
                         Math.Pow(coordinate.y - currentPosition.y, 2) +
                         Math.Pow(coordinate.z - currentPosition.z, 2) *
                                   1.0), 0.5);
            return distance;
        }
        public double GetFlyTime(Coordinate coordinate)
        {
            double distance = FlyTo(coordinate);
            float hours = 0;
            
            if(distance < 10000)
            {
                while (distance > speed)
                {
                    distance -= speed;
                    speed += acceleration;
                    hours += 1;
                }
                
            }
            return hours + distance / speed;
        }

        public override string ToString()
        {
            return ("Airplanes position: " + this.currentPosition + " & " + "speed: " + this.speed);
        }
    };

}
