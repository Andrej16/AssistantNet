using AssistantNet.Serialization;

namespace AssistantNet.Test;

[TestClass]
public sealed class SerializeAnDeserializeTests
{
    [TestInitialize]
    public void TestInit()
    {
        // This method is called before each test method.
    }

    [TestMethod]
    public void TestXmlSerialize_RequrementsMet_ExecutedSucceeded()
    {
        // Act 
        var a = Random.Shared.Next(1, 100);

        SerializeAnDeserialize.TestXmlSerialize();

        // Assert
        Assert.IsTrue(true);
    }
}
