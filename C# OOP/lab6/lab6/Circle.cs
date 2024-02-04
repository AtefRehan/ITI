using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Circle:Shape
    {
		private float radius;


		

		public Circle(float _radius):base(" Yellow Circle")
		{
			radius = _radius;
		}
		public float Radius
		{
			get { return radius; }
			set { radius = value; }
		}
		public override float  CalcArea()
		{
			return (float)(Math.PI * radius*radius);
		}
        public override void Draw()
        {

        }

    }
}
