using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
     abstract internal class Shape
    {
		private string color;

        public Shape()
        {
            
        }
        public Shape(string _color)
        {
            color = _color;
        }
        public string Color
		{
			get { return color; }
			set { color = value; }
		}
		public abstract float CalcArea();



		public abstract void Draw();
		

		

	}
}
