public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Correct way to modify the field: use the property
        MyProperty = 10;
        MyProperty = 20; //Further modification using property
    }
}