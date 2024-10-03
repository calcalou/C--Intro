namespace FormesGeometriques
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point()
        {
            x = 0;
            y = 0;
        }


        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point point = (Point)obj;
            return (x == point.x) && (y == point.y);
        }


        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
