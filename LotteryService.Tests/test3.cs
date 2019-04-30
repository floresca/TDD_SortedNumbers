using NUnit.Framework;
using LotteryService;


public class LotteryServiceThreeNumSortedTest
{
    [Test]
    public void Return_threeNumSorted()
    {
        Class1 obj = new Class1();
        int[] numArr = new int[] { 5, 1, 9 };
        obj.SortNumbers(numArr);
        var results = obj.SortNumbers(numArr);
        int[] numArr2 = new int[] { 1, 5, 9 };
        Assert.AreEqual(numArr2[0], results[0]);
    }
}