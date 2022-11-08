namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class DatabaseTests
    {
        private Database db;

        [SetUp]

        public void SetUp()
        {
            this.db = new Database();
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]

        public void ConstructurShouldAddLessThan16Elements(int[] elementsToAdd)
        {
            //Arrange
            Database testDB = new Database(elementsToAdd);

            //Action
            var actualSize = testDB.Fetch();
            var expectedSize = elementsToAdd;
            var actualCount = testDB.Count;
            var expectedCount = expectedSize.Length;

            //Assert

            CollectionAssert.AreEqual(expectedSize, actualSize,
                "Everything is fine");
            Assert.AreEqual(expectedCount, actualCount,
                "Constructor should intial field also correct");
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]

        public void ConstructorHaveMoreThan16Elements(int[] elementsToAdd)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Database testDB = new Database(elementsToAdd);
            }, "Array's capacity must be exactly 16 integers!");
        }
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void AddElementsMustLessThan16(int[] elementToAdd)
        {
            foreach (var el in elementToAdd)
            {
                this.db.Add(el);
            }

            int[] actualSize = this.db.Fetch();
            int[] expectedSize = elementToAdd;
            int actualCount = this.db.Count;
            int expectedCount = expectedSize.Length;

            CollectionAssert.AreEqual(expectedSize, actualSize, "Add should physically add the elements to the field!");
            Assert.AreEqual(expectedCount, actualCount, "Add should change the elements count when addidng!");

        }

        [Test]
        public void AddMoreThan16Elements()
        {

            for (int i = 1; i <= 16; i++)
            {
                this.db.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.db.Add(1);
            }, "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1 })]
        public void RemoveSuccessfullyElements(int[] startedElements)
        {
            foreach (var el in startedElements)
            {
                this.db.Add(el);
            }
            this.db.Remove();
            List<int> ellList = new List<int>(startedElements);

            ellList.RemoveAt(ellList.Count - 1);
            int[] actualSize = this.db.Fetch();
            int[] exceptedSize = ellList.ToArray();

            int actualCount = this.db.Count;
            int expectedCount = exceptedSize.Length;

            CollectionAssert.AreEqual(exceptedSize, actualSize, "Remove should physically remove element in the data field!");

            Assert.AreEqual(expectedCount, actualCount, "Remove should decrement the count of the Database!");
        }

        [Test]
        public void RemoveShouldRemoveTheLastElementMoreThanOnce()
        {
            List<int> initData = new List<int> { 1, 2, 3 };

            foreach (var el in initData)
            {
                this.db.Add(el);
            }

            for (int i = 0; i < initData.Count; i++)
            {
                this.db.Remove();
            }

            int[] actualSize = this.db.Fetch();
            int[] expectedSize = new int[] { };

            int actualCount = this.db.Count;
            int expectedCount = 0;

            CollectionAssert.AreEqual(expectedSize, actualSize, "Remove should physically remove element in the data field!");

            Assert.AreEqual(expectedCount, actualCount, "Remove should decrement the count of the Database!");
        }

        [Test]
        public void RemoveShouldThrowErrorWhenCollectionIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.db.Remove();
            }, "The collection is empty!");
        }


        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldREturnCoppyArra(int[] initData)
        {
            foreach (var el in initData)
            {
                this.db.Add(el);
            }

            int[] actualResult = this.db.Fetch();
            int[] expectedResult = initData;

            CollectionAssert.AreEqual(expectedResult, actualResult, "Fetch should return coppy of the existing data!");
        }
    }
}
