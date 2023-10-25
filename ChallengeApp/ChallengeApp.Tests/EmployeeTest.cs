namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void CheckIfMethodGetStatisticsCountsCorrectAverageGrade()
        {
            // arrange
            var employee1 = new Employee("Barry", "White");
            employee1.AddGrade(-4);
            employee1.AddGrade(4);
            employee1.AddGrade(-9);
            // act
            var statistics = employee1.GetStatistics();
            // assert
            Assert.AreEqual(-3, statistics.Average);
        }

        [Test]
        public void CheckIfMethodGetStatisticsCountsCorrectAverageGradeWhenAverageValueIsFloatType()
        {
            // arrange
            var employee1 = new Employee("Barry", "White");
            employee1.AddGrade(3);
            employee1.AddGrade(4);
            employee1.AddGrade(3);
            // act
            var statistics = employee1.GetStatistics();
            // assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void CheckIfMethodGetStatisticsCountsCorrectMinimumGrade()
        {
            // arrange
            var employee1 = new Employee("Barry", "White");
            employee1.AddGrade(-4);
            employee1.AddGrade(4);
            employee1.AddGrade(-9);
            // act
            var statistics = employee1.GetStatistics();
            // assert
            Assert.AreEqual(-9, statistics.Min);
        }

        [Test]
        public void CheckIfMethodGetStatisticsCountsCorrectMaximumGrade()
        {
            // arrange
            var employee1 = new Employee("Barry", "White");
            employee1.AddGrade(-4);
            employee1.AddGrade(4);
            employee1.AddGrade(-9);
            // act
            var statistics = employee1.GetStatistics();
            // assert
            Assert.AreEqual(4, statistics.Max);
        }

        [Test]
        public void WhenEmployeeCollectThreePositivePoints_ShouldReturnCorrectSumOfPoints()
        {
            // arrange
            var employee1 = new Employee("Barry", "White");
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
            var employee1 = new Employee("Barry", "White");
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