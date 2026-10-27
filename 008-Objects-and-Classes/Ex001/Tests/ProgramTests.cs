namespace Tests;

public class ProgramTests
{
    private static readonly string[] Songs =
        { "3", "favourite_DownTown_3:14", "favourite_Kiss_4:16", "listenLater_Ring_2:10" };

    [TestCase("favourite", "DownTown\nKiss")]
    [TestCase("all", "DownTown\nKiss\nRing")]
    public void Test_Ex001_FiltersSongsByList(string list, string expected)
    {
        Assert.That(ConsoleRunner.Run("Ex001", Songs.Append(list).ToArray()), Is.EqualTo(expected));
    }
}
