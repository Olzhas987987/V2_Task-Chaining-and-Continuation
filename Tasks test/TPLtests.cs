using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TPL;

namespace EPAM_Task_1

{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestTask1()
        {
            int[] array = ConsoleTPL.CreateRandomArray(10);
            Assert.AreEqual(array.Length, 10);
        }

        [TestMethod]
        public void TestTask2()
        {
            int[] array = ConsoleTPL.CreateRandomArray(10);
            int randomNumber = ConsoleTPL.GenerateRandomNumber();
            int[] multipliedArray = ConsoleTPL.MultiplyArray(array, randomNumber);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(multipliedArray[i], array[i]);
            }
        }

        [TestMethod]
        public void TestTask3()
        {
            int[] array = { 7, 3, 1, 5, 9, 2 };
            int[] sortedArray = { 1, 2, 3, 5, 7, 9 };
            Assert.IsTrue(sortedArray.SequenceEqual(ConsoleTPL.SortArray(array)));
        }
        [TestMethod]
        public void TestTask4()
        {
            int[] array = ConsoleTPL.CreateRandomArray(10);
            double average = ConsoleTPL.CalculateAverage(array);
            double expectedAverage = array.Average();
            Assert.AreEqual(average, expectedAverage);
        }
    }
}