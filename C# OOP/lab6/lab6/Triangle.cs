using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Triangle:Shape
    {
		private float dim1;
		private float dim2;
		private float dim3;
		private float area;

		
        public Triangle(float _dim1 , float _dim2 , float _dim3 ):base("Green Triangle")
        {
			dim1 = _dim1;	
			dim2 = _dim2;	
			dim3 = _dim3;
            
        }

        public float Area
		{
			get { return area; }
			set { area = value; }
		}

		public float Dim3
		{
			get { return dim3; }
			set { dim3 = value; }
		}


		public float Dim2
		{
			get { return dim2; }
			set { dim2 = value; }
		}

		public float Dim1
		{
			get { return dim1; }
			set { dim1 = value; }
		}

		public override float CalcArea()
		{
			area = (float) .5 * (dim1 * dim2);
			return area;

		}

        public override void Draw()
        {
        }
    }
}
