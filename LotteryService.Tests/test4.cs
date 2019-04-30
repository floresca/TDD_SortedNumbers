using NUnit.Framework;
using LotteryService;


public class LotteryServiceTenNumSortedTest
{
    [Test]
    public void Return_tenNumSorted()
    {
        Class1 obj = new Class1();
        int[] numArr = new int[] { 5, 1, 9, 10, 8, 7, 5, 500, 6970, 3};
        obj.SortNumbers(numArr);
        var results = obj.SortNumbers(numArr);
        int[] numArr2 = new int[] { 1, 3, 5, 5, 7, 8, 9, 10, 500, 6970};
        Assert.AreEqual(numArr2[0], results[0]);
        Assert.AreEqual(numArr2[5], results[5]);
    }
}