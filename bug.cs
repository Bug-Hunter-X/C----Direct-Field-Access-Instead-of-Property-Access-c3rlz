public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value;  }
    }

    public void MyMethod()
    {
        // Accessing _myField directly is not recommended.
        // The following line is prone to issues:
        _myField = 10;

        // Instead, use the MyProperty to modify the value:
        MyProperty = 20;
    }
}