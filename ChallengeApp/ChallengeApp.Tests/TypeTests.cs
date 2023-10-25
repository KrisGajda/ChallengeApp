namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestShouldReturntTrueIfStringTypeIsAValueType()
        {
            // arrange
            string name1 = "Adam";
            string name2 = "Adam";
            // assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void TestShouldReturntTrueIfIntegerTypeIsAValueType()
        {
            // arrange
            int age1 = 27;
            int age2 = 27;
            // assert
            Assert.AreEqual(age1, age2);
        }

        [Test]
        public void TestShouldReturntTrueIfFloatTypeIsAValueType()
        {
            // arrange
            float distanceInKilometers1 = 140.24f;
            float distanceInKilometers2 = 140.24f;
            // assert
            Assert.AreEqual(distanceInKilometers1, distanceInKilometers2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrange
            var user1 = GetEmployee("Adam", "Adamowski");
            var user2 = GetEmployee("Adam", "Adamowski");
            // assert
            Assert.AreNotEqual(user1, user2);
        }
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}