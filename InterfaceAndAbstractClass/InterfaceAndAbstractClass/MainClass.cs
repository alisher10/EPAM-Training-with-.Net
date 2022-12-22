namespace InterfaceAndAbstractClass {
    class MainClass
    {
        static void Main()
        {
            Bird bird = new Bird(new Coordinate(0, 0, 0));
            Airplane airplane = new Airplane(new Coordinate(1, 2, 3));
            Drone drone = new Drone(new Coordinate(5, 1, 3));
            Console.WriteLine(bird);
            Console.WriteLine(airplane);
            Console.WriteLine(drone + "\n");


            Console.WriteLine("Bird FlyTime: " + bird.GetFlyTime(new Coordinate(2, 3, 1)));
            Console.WriteLine("Airplane FlyTime: " + airplane.GetFlyTime(new Coordinate(500, 38, 232)));
            Console.WriteLine("Drone FlyTime: " + drone.GetFlyTime(new Coordinate(10, 10, 23)) + "\n");
            Console.WriteLine(bird);
            Console.WriteLine(airplane);
            Console.WriteLine(drone + "\n");


            bird.FlyTo(new Coordinate(2, 3, 1));
            airplane.FlyTo(new Coordinate(500, 38, 232));
            drone.FlyTo(new Coordinate(10, 10, 23));
            Console.WriteLine(bird);
            Console.WriteLine(airplane);
            Console.WriteLine(drone);
        }
    }
}