namespace lab4;

public class Fib: ISeries
{
    private int _current;
    private int _previous;

    public Fib()
    {
        _current = 1;
        _previous = 0;
    }

    public int Update()
    {
        
        int result = _current + _previous;
        _previous = _current;
        _current = result;
        return _current;


    }
    
}