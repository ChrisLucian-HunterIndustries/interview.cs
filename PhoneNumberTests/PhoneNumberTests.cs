namespace PhoneNumberTests;

[TestClass]
public class PhoneNumberTests
{
    [TestMethod]
    public void Test1()
    {
        PhoneNumber ph = new PhoneNumber("+1(858)775-2868");
        Assert.AreEqual("+1(858)775-2868", ph.GetOriginalText());
        Assert.AreEqual("+18587752868", ph.GetStrippedNumber());
        Assert.AreEqual("(858)775-2868", ph.GetValueAsNorthAmerican());
        Assert.AreEqual("+1.858.775.2868", ph.GetValueAsInternational());
    }

    [TestMethod]
    public void Test2()
    {
        PhoneNumber ph = new PhoneNumber("+1(858)775-2868x123");
        Assert.AreEqual("+1(858)775-2868x123", ph.GetOriginalText());
        Assert.AreEqual("+18587752868x123", ph.GetStrippedNumber());
        Assert.AreEqual("(858)775-2868x123", ph.GetValueAsNorthAmerican());
        Assert.AreEqual("+1.858.775.2868x123", ph.GetValueAsInternational());
    }

    [TestMethod]
    public void Test3()
    {
        PhoneNumber ph = new PhoneNumber("+598.123.4567x858");
        Assert.AreEqual("+598.123.4567x858", ph.GetOriginalText());
        Assert.AreEqual("+5981234567x858", ph.GetStrippedNumber());
        Assert.AreEqual(null, ph.GetValueAsNorthAmerican());
        Assert.AreEqual("+598.123.456.7x858", ph.GetValueAsInternational());
    }

    [TestMethod]
    public void Test4()
    {
        PhoneNumber ph = new PhoneNumber("+27 1234 5678 ext 4");
        Assert.AreEqual("+27 1234 5678 ext 4", ph.GetOriginalText());
        Assert.AreEqual("+2712345678x4", ph.GetStrippedNumber());
        Assert.AreEqual(null, ph.GetValueAsNorthAmerican());
        Assert.AreEqual("+27 1234 5678 ext 4", ph.GetValueAsInternational());
    }

    [TestMethod]
    public void Test5()
    {
        PhoneNumber ph = new PhoneNumber("858-775-2868");
        Assert.AreEqual("858-775-2868", ph.GetOriginalText());
        Assert.AreEqual("+18587752868", ph.GetStrippedNumber());
        Assert.AreEqual("(858)775-2868", ph.GetValueAsNorthAmerican());
        Assert.AreEqual("+1.858.775.2868", ph.GetValueAsInternational());
    }

}