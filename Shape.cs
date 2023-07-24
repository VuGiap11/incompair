using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icomparable
{
    public class Shape
    {
        private string color = "green";
        private bool filled = true;

        public Shape()
        {

        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string getColor()
        {
            return color;
        }
        public string setColor(string color)
        {
            return this.color = color;
        }
        public bool isFilled()
        {
            return filled;
        }
        public void setFilled(bool filled)
        {
            this.filled = filled;
        }

        public override string ToString()
        {
            return "A Shape with color of "
              + getColor()
              + " and "
              + (isFilled() ? "filled" : "not filled");
        }
    }
    public class Circle : Shape
    {
        private double radius = 1.0;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, String color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override string ToString()
        {
            return "A Circle with radius="
                    + getRadius()
                    + ", which is a subclass of "
                    + base.ToString();
        }
    }
    public class ComperableCircle : Circle, IComparable<ComperableCircle>
    {

        public ComperableCircle() { }
        public ComperableCircle(double radius) : base(radius) { }
        public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        public int CompareTo(ComperableCircle o)
        {
            if (getRadius() > o.getRadius()) return 1;
            else if (getRadius() < o.getRadius()) return -1;
            else return 1;
        }
    }

}

