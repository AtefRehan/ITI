namespace ConsoleApp1;

public class StackGenerics<g>
{
    private int tos;
    private int size;
    private g[] arr;
    
    
    public StackGenerics(int _size)
    {
        tos = 0;
        size = _size;
        arr = new g[size];
    }

    public g Push(g element)
    {
        if (tos == size)
        {
            throw new Exception("Your Stack Is Full !");
        }
       
            arr[tos] = element;
            tos++;
            return element;
        
    }
  
    public g Pop()
    {
        tos--;
        if(tos>=0)
            return arr[tos];

        throw new Exception("Your Stack is Empty");
    }
    
    

}