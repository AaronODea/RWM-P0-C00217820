using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class XOR21FilterTest
    {
        [Test]
        public void XOR21Simple()
        {
            //Assert.IsTrue(false);
             
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = XOR21Filter.XOR21s(input);
            int[] expected = { 17, 23, 29, 22, 28, 17, 31 };

           

            CollectionAssert.AreEqual(expected, output);
        }
    }
}