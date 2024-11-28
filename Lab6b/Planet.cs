using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6b
{
    
    public class Planet
    {
        public string name;
        public string description;
        public int size;
        public Color color;
        // public Point location;
        public Point centerLocation;
        public double speed;
        public double transition;
        public int distanceFromCenter;
        public Planet(string name, int size, Color color, Point planetCenter, Point solarSystemCenter, double speed)
        {
            this.name = name;
            this.size = size;
            this.color = color;
            this.centerLocation = planetCenter;
            this.speed = speed;
            this.transition = 0;
            this.distanceFromCenter = Distance(planetCenter, solarSystemCenter);
        }

        public int Distance(Point planetCenter,Point universeCenter)
        {
            double xDistance = Math.Pow(planetCenter.X - universeCenter.X, 2);
            double yDistance = Math.Pow(planetCenter.Y - universeCenter.Y, 2);
            int distance = (int)Math.Sqrt(xDistance + yDistance);
            return distance;
        }
    }
    
}
