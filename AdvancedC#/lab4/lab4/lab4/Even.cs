namespace lab4;

public class Even:ISeries
{
    private int _current;

    public Even()
    {

        _current = 0;
    }

    public int Update()
    {
        int evenNumber = _current;
        _current += 2;
        return evenNumber;
    }
}

