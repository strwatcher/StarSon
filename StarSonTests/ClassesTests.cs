using StarSON;

namespace StarSONTests;

public class Point
{
    public int a;
    public int b;
    private int c = 2;
}

public class ComplexClass
{
    public int a;
    public List<object> b;
    public Dictionary<string, object> c;

    public ComplexClass(int A, List<object> B, Dictionary<string, object> C)
    {
        a = A;
        b = B;
        c = C;
    }
}

public class ClassesTests
{
    private StarSON.StarSON serializer = new StarSON.StarSON();

    [Test]
    public void SimpleClassTest()
    {
        Point p = new Point {a = 1, b = 3};
        Assert.That(serializer.Serialize(p), Is.EqualTo("{class:\"StarSONTests.Point\",a:1,b:3}"));
    }

    [Test]
    public void ComplexClassTest()
    {
        ComplexClass test =
            new ComplexClass(5, new List<object> {1, 2, 3}, new Dictionary<string, object> {{"12", 123}});
        Assert.That(serializer.Serialize(test), Is.EqualTo("{class:\"StarSONTests.ComplexClass\",a:5,b:[1,2,3],c:{12:123}}"));
    }
}