using TestApp;

namespace Tests;

public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        Assert.That(StringRotator.RotateRight(string.Empty, 2), Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        Assert.That(StringRotator.RotateRight("abc", 0), Is.EqualTo("abc"));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        Assert.That(StringRotator.RotateRight("abcde", 2), Is.EqualTo("deabc"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_RotatesByAbsoluteValue()
    {
        Assert.That(StringRotator.RotateRight("abcde", -2), Is.EqualTo("deabc"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_WrapsAround()
    {
        Assert.That(StringRotator.RotateRight("abc", 4), Is.EqualTo("cab"));
    }
}
