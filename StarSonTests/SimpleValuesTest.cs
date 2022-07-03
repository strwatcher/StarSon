using StarSON;

namespace StarSONTests;

public class Tests
{
    [Test]
    public void IntegerTest()
    { 
        StarSON.StarSON serializer = new StarSON.StarSON();
        Assert.That(serializer.Serialize(5), Is.EqualTo("5"));
    }

    [Test]
    public void LongTest()
    {
        StarSON.StarSON serializer = new StarSON.StarSON();
        Assert.That(serializer.Serialize(5l), Is.EqualTo("5"));
    }
    
    [Test]
    public void FloatTest()
    {
        StarSON.StarSON serializer = new StarSON.StarSON();
        Assert.That(serializer.Serialize(5.123f), Is.EqualTo("5.123"));
    }
    
    [Test]
    public void DoubleTest()
    {
        StarSON.StarSON serializer = new StarSON.StarSON();
        Assert.That(serializer.Serialize(5.132), Is.EqualTo("5.132"));
    }
    
    [Test]
    public void DecimalTest()
    {
        StarSON.StarSON serializer = new StarSON.StarSON();
        Assert.That(serializer.Serialize(5.111m), Is.EqualTo("5.111"));
    }

    [Test]
    public void StringTest()
    {
        StarSON.StarSON serializer = new StarSON.StarSON();
        Assert.That(serializer.Serialize("lkfad"), Is.EqualTo("\"lkfad\""));
    }
}