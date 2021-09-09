using NUnit.Framework;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Test]
    public void Test1()
    {
        int test1 = 10;
        int test2 = 10;
        
        Assert.IsTrue(test1 == test2);
        
        var a = test1 - 1;
        var b = test2;
        
        Assert.IsTrue(a == b);
    }
}
