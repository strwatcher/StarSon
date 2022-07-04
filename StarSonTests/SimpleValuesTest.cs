using StarSON;

namespace StarSONTests;

public class Tests
{
    StarSON.StarSON serializer = new StarSON.StarSON();
    [Test]
    public void IntegerTest()
    { 
        Assert.That(serializer.Serialize(5), Is.EqualTo("5"));
    }

    [Test]
    public void LongTest()
    {
        Assert.That(serializer.Serialize(5l), Is.EqualTo("5"));
    }
    
    [Test]
    public void FloatTest()
    {
        Assert.That(serializer.Serialize(5.123f), Is.EqualTo("5.123"));
    }
    
    [Test]
    public void DoubleTest()
    {
        Assert.That(serializer.Serialize(5.132), Is.EqualTo("5.132"));
    }
    
    [Test]
    public void DecimalTest()
    {
        Assert.That(serializer.Serialize(5.111m), Is.EqualTo("5.111"));
    }

    [Test]
    public void StringTest()
    {
        Assert.That(serializer.Serialize("lkfad"), Is.EqualTo("\"lkfad\""));
    }

    [Test]
    public void BoolTest()
    {
        Assert.That(serializer.Serialize(true), Is.EqualTo("True"));
    }
}