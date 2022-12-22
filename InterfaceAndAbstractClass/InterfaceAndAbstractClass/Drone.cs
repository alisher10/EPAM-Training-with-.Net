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
        public void FlyTo(Coordinate coordinate)
        {
            if (coordinate.x < 1000 && coordinate.y < 1000 && coordinate.z < 1000)
            {
                currentPosition = coordinate;
            }
            else {
                currentPosition = new Coordinate(0, 0, 0);
            }
        }
        public bool AllowedRange(Coordinate c)
        {
            float distance = (c.x - currentPosition.x) * (c.x - currentPosition.x) +
                (c.y - currentPosition.y) * (c.y - currentPosition.y) + (c.z - currentPosition.z) *
                (c.z - currentPosition.z);
            
            if (distance < 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public float GetFlyTime(Coordinate coordinate)
        {
            if (AllowedRange(coordinate))
            {
                float distance = (coordinate.x - currentPosition.x) * (coordinate.x - currentPosition.x) + (coordinate.y - currentPosition.y) *
                    (coordinate.y - currentPosition.y) + (coordinate.z - currentPosition.z) * (coordinate.z - currentPosition.z);
                
                return (float)(distance / speed * 1.1);
            }
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {
            return ("Drones position: " + this.currentPosition + " & " + "speed: " + this.speed);
        }
    };
}
