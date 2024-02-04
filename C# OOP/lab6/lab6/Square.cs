using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Square:Rectangle

    {
        
        public Square():base(5,5)
        {
            Color = " black Square  ";
        }
        public override float CalcArea()
        {
            return Dim1 * Dim1;
        }
    }
}
