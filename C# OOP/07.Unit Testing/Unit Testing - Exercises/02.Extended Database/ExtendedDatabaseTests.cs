namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    public class ExtendedDatabaseTests
    {

        [Test]
        public void AddsPeopleShouldIncreaseCount()
        {
            var db = new Database();

            db.Add(new Person(12345678, "Yordan"));
            db.Add(new Person(87654321, "Gabriela"));

            Assert.AreEqual(2, db.Count);
        }

        [Test]
        public void PeronsWithTheSameNameWillThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var db = new Database();

                db.Add(new Person(12345678, "Yordan"));
                db.Add(new Person(87654321, "Yordan"));

            }, "There is already user with this username!");
        }

        [Test]
        public void PersonsWithTheSameIdWillThrowException()
        {
            Assert.Throws<InvalidOperationException>
                (() =>
                {
                    var db = new Database();
                    db.Add(new Person(12345678, "Yordan"));
                    db.Add(new Person(12345678, "Yon"));

                }, "There is already user with this Id!");
        }

        [Test]
        public void PeronsCountMoreThan16PeopleThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var db = new Database();
                db.Add(new Person(1, "A"));
                db.Add(new Person(2, "B"));
                db.Add(new Person(3, "C"));
                db.Add(new Person(4, "D"));
                db.Add(new Person(5, "E"));
                db.Add(new Person(6, "F"));
                db.Add(new Person(7, "G"));
                db.Add(new Person(8, "H"));
                db.Add(new Person(9, "I"));
                db.Add(new Person(10, "J"));
                db.Add(new Person(11, "K"));
                db.Add(new Person(12, "L"));
                db.Add(new Person(13, "M"));
                db.Add(new Person(14, "N"));
                db.Add(new Person(15, "O"));
                db.Add(new Person(16, "P"));
                db.Add(new Person(17, "Yordan"));
            }, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void WhenAddRangeWrongAmoundOfPeopleShoudThrowExeption()
        {
            var array = new Person[21];

            for (int i = 0; i <= 20; i++)
            {
                var sb = new StringBuilder();
                var sb1 = new StringBuilder();
                sb.Append("Yordan");
                sb.Append(i);
                array[i] = new Person(2 + i, sb.ToString());
            }
            Assert.Throws<ArgumentException>(() => new Database(array));
        }

        [Test]
        public void WhenAddRangeCountCorrectly()
        {
            var perons = new Person(858585, "YordanMiroslavov");
            Assert.LessOrEqual(perons.Id.ToString().Length, 16);
            Assert.LessOrEqual(perons.UserName.ToString().Length, 16);

        }
        [Test]
        public void RemoveOnePerson()
        {
            var db = new Database();
            db.Add(new Person(1, "A"));
            db.Add(new Person(2, "B"));
            db.Remove();
            Assert.AreEqual(1, db.Count, "Successufully removed one person");
        }

        [Test]
        public void RemoveMoreThanOnePersons()
        {
            Assert.Throws<InvalidOperationException>(() =>
                   {
                       var db = new Database(new Person[0]);
                       db.Remove();
                   }, "The Persons cannot be equal to zero!");
        }

        [Test]
        public void FindByUserShouldReturnCorrectPerson()
        {
            var db = new Database();
            db.Add(new Person(1, "A"));
            db.Add(new Person(2, "B"));
            db.Add(new Person(3, "C"));
            db.Add(new Person(4, "D"));
            db.Add(new Person(5, "E"));

            var nameA = db.FindByUsername("A");
            var checkIdA = new Person(1, "A");

            Assert.AreEqual(checkIdA.UserName, nameA.UserName);
            Assert.AreEqual(checkIdA.Id, nameA.Id);
        }

        [Test]
        public void FindByUsernameShoudThrowExeptionWhenReceiveCorrectButCaseSensitiveName()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var db = new Database();
                db.Add(new Person(1, "A"));
                db.Add(new Person(2, "B"));
                db.Add(new Person(3, "C"));
                db.Add(new Person(4, "D"));
                db.Add(new Person(5, "E"));
                db.FindByUsername("a");
            }, "User doesn't exist !");
        }

        [Test]
        public void FindByUsernameShoudThrowExeptionWhenReceiveNullOrEmpty()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var db = new Database();
                db.Add(new Person(5, "a"));
                db.FindByUsername(null);
            }, "Username parameter is null!");
        }

        [Test]
        public void FindByIDShouldReturnCorrectPerson()
        {
            var db = new Database();
            db.Add(new Person(1, "A"));
            db.Add(new Person(2, "B"));
            db.Add(new Person(3, "C"));
            db.Add(new Person(4, "D"));
            db.Add(new Person(5, "E"));


            var idToFInd = db.FindById(2);

            Assert.AreEqual(2, idToFInd.Id);
        }

        [Test]
        public void FindByIDShoudThrowExeptionWhenReceiveNullOrEmpty()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var db = new Database();
                db.Add(new Person(-1, "a"));
                db.FindById(-1);
            }, "Id should be a positive number!");
        }

        [Test]
        public void FindByIDShouldThrowExecptionWhenInvalidID()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var db = new Database();
                db.Add(new Person(1, "a"));
                db.FindById(11);

            }, "No user is present by this ID!");
        }
    }
}