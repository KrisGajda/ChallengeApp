namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectThreePositivePoints_ShouldReturnCorrectSumOfPoints()
        {
            // arrange
            var employee1 = new Employee("Barry", "White", 55);
            employee1.AddGrade(4);
            employee1.AddGrade(5);
            employee1.AddGrade(3);
            // act
            var employeePointsSum = employee1.Score;
            // assert
            Assert.AreEqual(12, employeePointsSum);
        }

        [Test]
        public void WhenEmployeeCollectSomeMinusPoints_ShouldReturnCorrectSumOfPoints()
        {
            // arrange
            var employee1 = new Employee("Barry", "White", 55);
            employee1.AddGrade(4);
            employee1.AddGrade(-5);
            employee1.AddGrade(-3);
            // act
            var employeePointsSum = employee1.Score;
            // assert
            Assert.AreEqual(-4, employeePointsSum);
        }
    }
}