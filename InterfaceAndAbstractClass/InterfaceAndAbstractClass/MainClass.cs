namespace InterfaceAndAbstractClass {
    class MainClass
    {
        public static void Main()
        {
            Bird bird = new Bird(new Coordinate(0, 0, 0));
            Airplane airplane = new Airplane(new Coordinate(1, 2, 3));
            Drone drone = new Drone(new Coordinate(5, 1, 3));

            Console.WriteLine("Initial Position:");
            Console.WriteLine(bird);
            Console.WriteLine(airplane);
            Console.WriteLine(drone + "\n");

            Console.WriteLine("Birds Fly time: " + bird.GetFlyTime(new Coordinate(2, 3, 1)).ToString("0.00"));
            Console.WriteLine("Drones Fly time: " + drone.GetFlyTime(new Coordinate(10, 12, 14)).ToString("0.00"));
            Console.WriteLine("Airplanes Fly time: " + airplane.GetFlyTime(new Coordinate(20, 15, 20)).ToString("0.00"));

        }
    }
}
