
namespace Library.Tests;


public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCorrectDate()
    {
        const string dateExpected = "1997-10-11";
        const string dateTest = "11/10/1997";
        string dateFormattedTest = TestDateFormat.DateFormatter.ChangeFormat(dateTest);

        Assert.AreEqual(dateFormattedTest, dateExpected);
    }
    [Test]
    public void TestWrongDate()
    {
        const string dateExpected = "1997-10-11";
        const string dateTest = "11/1997/10";
        string dateFormattedTest = TestDateFormat.DateFormatter.ChangeFormat(dateTest);

        Assert.AreNotEqual(dateFormattedTest, dateExpected);
    }
    [Test]
    public void TestEmptyDate()
    {
        const string dateTest = "";

        Assert.Throws<ArgumentOutOfRangeException>(() => TestDateFormat.DateFormatter.ChangeFormat(dateTest));
    }
}