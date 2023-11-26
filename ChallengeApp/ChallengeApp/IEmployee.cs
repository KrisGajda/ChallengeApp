namespace ChallengeApp
{
    public interface IEmployee
    {
        
        string Name { get; }
        string Surname { get; }
        char Sex { get; }
        int Age { get; }
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(long grade);
        Statistics GetStatistics();
    }
}
