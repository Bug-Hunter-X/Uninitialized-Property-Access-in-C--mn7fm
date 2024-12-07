public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it is assigned a value
        Console.WriteLine(MyProperty); // This may result in unexpected behavior due to default value
    }
}