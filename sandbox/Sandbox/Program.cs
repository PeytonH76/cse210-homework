class Program {
    static void Main(string[] args) {
        
        var divider =  new IntegerDivision();
        divider._lhs = 10;
        divider._rhs = 1;
        divider.DisplayResult();

        divider._lhs = 0;
        divider._rhs = 100;
        divider.DisplayResult();

        divider._lhs = 5;
        divider._rhs = 0;
        divider.DisplayResult();

        divider._lhs = 25;
        divider._rhs = 5;
        divider.DisplayResult();
    }
}

class IntegerDivision {
    public int _lhs = 1;
    public int _rhs = 1;

    public int GetLHS() 
    {
        return _lhs;
    }

    public void SetLHS(int newLHS)
    {
        _lhs = newLHS;
    }


    public int GetRHS() 
    {
        return _rhs;
    }

    public void SetRHS(int newRHS)
    {
        if (newRHS == 0) 
        {
            Console.WriteLine("Hey, you can't divide by zero! Defaulting RHS to one.");
            _rhs = 1;
        }
        else{
            _rhs = newRHS;
        }
    }
    

    public int Result() {
        return _lhs / _rhs;
    }

    public void DisplayResult() {
        var result = Result();
        Console.WriteLine($"{_lhs} divided by {_rhs} is {result}");
    }
}