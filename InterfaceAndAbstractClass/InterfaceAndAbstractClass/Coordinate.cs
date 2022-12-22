namespace InterfaceAndAbstractClass
{
    struct Coordinate
    {
        public uint x;
        public uint y;
        public uint z;
        public Coordinate(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return (this.x + ", " + this.y + ", " + this.z);
        }
    };
}
