using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }
        
        public override bool Equals(object ? obj)
        {
            if (obj == null)
                return false;
            if(this.GetType()!=obj.GetType()) 
                return false;

            var rhs=  (Complex)obj;
            
            if(rhs.Real ==Real && rhs.Img == Img) 
                return true;
            else 
                return false;

            //return base.Equals(obj);
        }
        public static bool operator==(Complex lhs, Complex rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return !lhs.Equals(rhs);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }


    
}
