using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProject.World.Entity
{
    abstract class EntityAbstract
    {
        
        public double x { get; set; }
        public double y { get; set; }
        public double dx { get; set; }
        public double dy { get; set; }
        public double drot { get; set; }
        public double Rotation { get; set; }
        public double Speed { get; set; }
        public double Radius { get; set; }
        public int Collision { get; set; }
        public int Points { get; set; }
        public string Colour { get; set; }
        public int Weight { get; set; }

        protected double degree_to_rad = Math.PI / 180;
        protected double rad_to_degree = 180 / Math.PI;

        public EntityAbstract() { }
        public EntityAbstract(int x, int y, double Rotation, double Speed, double Radius, int Collision, int Points, string Colour, int Weight)
        {
            dx = 0.0d;
            dy = 0.0d;
            drot = 0.0d;

            this.Speed = Speed;
            this.x = x;
            this.y = y;
            this.Rotation = Rotation;
            this.Radius = Radius;
            this.Collision = Collision;
            this.Points = Points;
            this.Colour = Colour;
            this.Weight = Weight;

        }
    }
}
