using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Rectangle:Shape
    {
		private float dim1;
		private float dim2;
		private float area;


       
        public Rectangle(float _dim1, float _dim2) :base(" Red Rectangle") { 
			dim1 = _dim1;
			dim2 = _dim2;	
		}

		public float Area
		{
			get { return area; }
			set { area = value; }
		}


		public float Dim1
		{
			get { return dim1; }
			set { dim1 = value; }
		}
		public float Dim2
		{
			get { return dim2; }
            set { dim2 = value; }
        }

		public  override float CalcArea()
		{	
			area= dim1 * dim2;
			return area;
		}

        public override void Draw()
        {
        }
    }
}
