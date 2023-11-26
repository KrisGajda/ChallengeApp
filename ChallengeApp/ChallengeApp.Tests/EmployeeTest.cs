namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void CheckIfMethodGetStatisticsCountsCorrectAverageGrade()
        {
            // arrange
            var employee1 = new EmployeeInMemory("Barry", "White");
            employee1.AddGrade(4);
            employee1.AddGrade(5);
            employee1.AddGrade(9);
            // act
            var statistics = employee1.GetStatistics();
            // assert
            Assert.AreEqual(6, statistics.Average);
        }

        [Test]
        public void CheckIfMethodGetStatisticsCountsCorrectAverageGradeWhenAverageValueIsFloatType()
        {
            // arrange
            var employee1 = new EmployeeInMemory("Barry", "White");
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
            var employee1 = new EmployeeInMemory("Barry", "White");
            employee1.AddGrade(10);
            employee1.AddGrade(40);
            employee1.AddGrade(90);
            // act
            var statistics = employee1.GetStatistics();
            // assert
            Assert.AreEqual(10, statistics.Min);
        }

        [Test]
        public void CheckIfMethodGetStatisticsCountsCorrectMaximumGrade()
        {
            // arrange
            var employee1 = new EmployeeInMemory("Barry", "White");
            employee1.AddGrade(60);
            employee1.AddGrade(50);
            employee1.AddGrade(40);
            // act
            var statistics = employee1.GetStatistics();
            // assert
            Assert.AreEqual(60, statistics.Max);
        }

        [Test]
        public void WhenEmployeeCollectThreePositivePoints_ShouldReturnCorrectSumOfPoints()
        {
            // arrange
            var employee1 = new EmployeeInMemory("Barry", "White");
            employee1.AddGrade(40);
            employee1.AddGrade(50);
            employee1.AddGrade(30);
            // act
            var employeePointsSum = employee1.Score;
            // assert
            Assert.AreEqual(120, employeePointsSum);
        }

        [Test]
        public void ReturnCorrectEmployeeFinalGrade_C()
        {
            // arrange
            var employee = new EmployeeInMemory();
            employee.AddGrade(50);
            employee.AddGrade(50);
            employee.AddGrade(50);
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}