public class Complex
{
    public int real { get; set; }
    public int img { get; set; }

    public Complex()
    {
    }


    public override bool Equals(object obj)
    {
        if (this.GetType() != obj.GetType() || obj == null)
        { 
            return false;
        }
    
        var rhs = obj as Complex;
    
        if (rhs.real == real && rhs.img == img)
            return true;
        else
            return false;
    }

    public static bool operator ==(Complex obj1 , Complex obj2)
    {
    
        return obj1.Equals(obj2);
        
    }
    public static bool operator !=(Complex obj1 , Complex obj2)
    {
        return !(obj1 == obj2);
    }

    public override string ToString()
    {

        if (img > 0)
        {
            return $"{real}+{img}J";
        }
        else if (img < 0)
        {
            return $"{real}{img}J";
        }
        else
        {
            return $"{real}";
        }
    }



    public void Print()
    {
        Console.WriteLine($"{ToString()}");
    }
}