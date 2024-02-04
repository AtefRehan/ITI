namespace lab4;

public class Odd:ISeries
{
    private int _current;

    public Odd()
    {

        _current = 1;
    }

    public int Update()
    {
        int oddNumber = _current;
        _current += 2;
        return oddNumber;
    }
}