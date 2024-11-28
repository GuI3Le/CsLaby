using System.Xml.Serialization;

namespace Lab6b
{
    public partial class Form1 : Form
    {
        public Point center = new System.Drawing.Point(900,500);
        public List<Planet> celestialBodies = new();
        public int sunSize = 120;

        public Form1()
        {
        InitializeComponent();
        Planet sun = new Planet("Sun", sunSize, Color.FromArgb(242, 131, 32), center,center, 0);
        celestialBodies.Add(sun);
        Planet mercury = new Planet("Mercury",sunSize / 5, Color.FromArgb(90, 88, 86), new Point(center.X + 80,center.Y),center, Math.PI/64);
        celestialBodies.Add(mercury);
        Planet venus = new Planet("Venus", sunSize /4, Color.FromArgb(135, 138, 141), new Point(center.X + 140, center.Y), center, Math.PI / 96);
        celestialBodies.Add(venus);
        Planet earth = new Planet("Earth", sunSize/4, Color.FromArgb(32, 56, 112), new Point(center.X + 200, center.Y), center, Math.PI / 128);
        celestialBodies.Add((earth));
        Planet mars = new Planet("Mars", sunSize/5, Color.FromArgb(242, 123, 95), new Point(center.X + 260, center.Y), center,
            Math.PI / 160);
        celestialBodies.Add(mars);
        Planet jupiter = new Planet("Jupiter", sunSize / 2, Color.FromArgb(192, 130, 55), new Point(center.X + 320, center.Y),center,
            Math.PI / 256);
        celestialBodies.Add(jupiter);
        Planet saturn = new Planet("Saturn", sunSize/3, Color.FromArgb(243, 206, 136), new Point(center.X + 380, center.Y),
            center, Math.PI / 512);
        celestialBodies.Add(saturn);
        Planet uranus = new Planet("Uranus", sunSize /4, Color.FromArgb(208, 236, 240), new Point(center.X + 440, center.Y),
            center, Math.PI / 1024);
        celestialBodies.Add(uranus);
        Planet neptune = new Planet("Neptune", sunSize /4, Color.FromArgb(101, 123, 165), new Point(center.X + 500, center.Y),
            center, Math.PI / 2048);
        celestialBodies.Add(neptune);
        foreach (var planet in celestialBodies)
        {
            CreatePlanetButton(planet.name, planet.size,planet.color,planet.centerLocation);
        }
        //ShapyButton.ShapyButton sun = new ShapyButton.ShapyButton(300, 200);
        // sun.Name = "shapyButton1";
        // sun.BackgroundColor = Color.FromArgb(242, 131, 31);
        // this.Controls.Add(sun);
        }

        public void CreatePlanetButton(string name, int size, Color color, Point location)
        {
            ShapyButton.ShapyButton planet = new ShapyButton.ShapyButton(name, size,color,location);
            this.Controls.Add(planet);
        }

        private ShapyButton.ShapyButton GetButtonByName(string name)
        {
            Control[] controls = this.Controls.Find(name, true);
            if (controls.Length > 0 && controls[0] is ShapyButton.ShapyButton shapyButton)
            {
                return shapyButton;
            }

            return null;
        }

        public void UpdatePlanetButton(Planet planet)
        {
            if (planet.speed != 0)
            {
                ShapyButton.ShapyButton planetButton = GetButtonByName(planet.name);
                planetButton.Location = new Point(planet.centerLocation.X - planet.size / 2,
                    planet.centerLocation.Y - planet.size / 2);
            }
        }

        public void UpdateLocation(Planet planet)
        {
            if (planet.speed != 0)
            {
                planet.transition += planet.speed % (2*Math.PI);
                
                int newX = (int)(center.X + planet.distanceFromCenter * Math.Cos(planet.transition));
                int newY = (int)(center.Y + planet.distanceFromCenter * Math.Sin(planet.transition));
                planet.centerLocation = new Point(newX, newY);
            }
        }

        

        private void TimerTick(object sender, EventArgs e)
        {
            foreach (var planet in celestialBodies)
            {
                UpdateLocation(planet);
                UpdatePlanetButton(planet);
            }
        }

        
    }
}
