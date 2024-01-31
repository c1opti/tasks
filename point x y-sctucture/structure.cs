using System.Xml.Linq;

namespace structurepoint
{
    internal class structure
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            Point cons = new Point(x.Next(11), x.Next(11), x.Next(11), x.Next(11));
            cons.x1 = x.Next(11);
            cons.x2 = x.Next(11);
            cons.y1 = x.Next(11);
            cons.y2 = x.Next(11);
            cons.Distance();
        }
    }
    struct Point
    {
        public int x1;
        public int x2;
        public int y1;
        public int y2;
        public Point(int x1, int x2, int y1, int y2) { this.x1 = x1; this.x2 = x2; this.y1 = y1; this.y2 = y2; }
        public void Distance()
        {
            double distance = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
            Console.WriteLine($"Distance {distance}");
        }
    }
}
// в жопу эти конструкторы реально