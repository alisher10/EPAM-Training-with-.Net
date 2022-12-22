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

        public void FlyTo(Coordinate coordinate)
        {
            currentPosition = coordinate;
        }

        public float GetFlyTime(Coordinate coordinate)
        {
            float distance = (coordinate.x - currentPosition.x) * (coordinate.x - currentPosition.x) +
                (coordinate.y - currentPosition.y) * (coordinate.y - currentPosition.y) + 
                (coordinate.z - currentPosition.z) * (coordinate.z - currentPosition.z);

            return distance / speed;
        }

        public override string ToString()
        {
            return ("Birds position: " + this.currentPosition + " & " + "speed: " + this.speed);
        }
    };

}
