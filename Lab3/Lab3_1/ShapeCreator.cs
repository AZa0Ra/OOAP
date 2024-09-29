using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class ShapeCreator
    {
        public abstract Shape CreateShape();
    }
    class CircleCreator : ShapeCreator
    {
        private double _radius;
        private string _color;
        public CircleCreator(double radius, string color) 
        {
            _radius = radius;
            _color = color;
        }

        public override Shape CreateShape()
        {
            return new Circle(_radius, _color);
        }
    }
    class RectangleCreator : ShapeCreator
    {
        private double _height;
        private double _width;
        private string _color;
        public RectangleCreator(double width, double height, string color)
        {
            _width = width;
            _height = height;
            _color = color;
        }
        public override Shape CreateShape()
        {
            return new Rectangle(_width, _height, _color);
        }
    }
}
