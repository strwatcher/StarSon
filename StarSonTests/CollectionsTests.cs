using StarSON;

namespace StarSONTests;

public class CollectionsTests
{
    private StarSON.StarSON serializer = new();
    
    [Test]
    public void ArrayWithSimpleValuesTest()
    {
        Assert.That(serializer.Serialize(new List<object> {"af", 12, 4.12}), Is.EqualTo("[\"af\",12,4.12]"));
    }

    [Test]
    public void ArrayWithNestingValuesTest()
    {
        Assert.That(serializer.Serialize(new List<object> {"af", new List<object>{12, 132, "12"}}), Is.EqualTo("[\"af\",[12,132,\"12\"]]"));
    }

    [Test]
    public void DictWithSimpleValuesTest()
    {
        Assert.That(serializer.Serialize(new Dictionary<string, object>
        {
            {"key1", 1231}, {"key2", "123"}, {"key3", new List<object>{1, 2, 3}}
        }), Is.EqualTo("{key1:1231,key2:\"123\",key3:[1,2,3]}"));
    }

    [Test]
    public void DictWithNestedDictTest()
    {
        Assert.That(
            serializer.Serialize(
                new Dictionary<string, object>{{"key1", new Dictionary<string, object>{{"key2", 1}}}}),
            Is.EqualTo("{key1:{key2:1}}"));
    }
}