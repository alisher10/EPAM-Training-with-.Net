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
        public void FlyTo(Coordinate coordinate)
        {
            currentPosition = coordinate;
        }
        public float GetFlyTime(Coordinate coordinate)
        {
            float distance = (coordinate.x - currentPosition.x) * (coordinate.x - currentPosition.x) + 
            (coordinate.y - currentPosition.y) * (coordinate.y - currentPosition.y) + 
            (coordinate.z - currentPosition.z) * (coordinate.z - currentPosition.z);
            float hours = 0;
            
            while(distance < 10000)
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
