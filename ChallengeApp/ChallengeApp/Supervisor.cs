namespace ChallengeApp
{
    public class Supervisor : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        List<float> grades = new List<float>();
        public Supervisor(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }
        public Supervisor(string name, string surname)
            : this(name, surname, '-', 0) { }
        public Supervisor()
            : this("NoName", "NoSurname", '-', 0) { }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        private char sex;
        public char Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value == 'K' || value == 'M' || value == '-')
                    sex = value;
                else
                {
                    throw new Exception("Podaj płeć \"K\" (kobieta) lub \"M\" (mężczyzna) lub \"-\"");
                }
            }
        }
        public int Age { get; private set; }
        public float Score { get; private set; }

        public override void AddGrade(string grade)

        {
            if (grade.Contains('-') || grade.Contains('+'))
            {
                switch (grade)
                {
                    case "1+":
                    case "+1":
                        AddGrade(5f);
                        break;
                    case "-2":
                    case "2-":
                        AddGrade(15f);
                        break;
                    case "2+":
                    case "+2":
                        AddGrade(25f);
                        break;
                    case "-3":
                    case "3-":
                        AddGrade(35f);
                        break;
                    case "3+":
                    case "+3":
                        AddGrade(45f);
                        break;
                    case "-4":
                    case "4-":
                        AddGrade(55f);
                        break;
                    case "4+":
                    case "+4":
                        AddGrade(65f);
                        break;
                    case "-5":
                    case "5-":
                        AddGrade(75f);
                        break;
                    case "5+":
                    case "+5":
                        AddGrade(85f);
                        break;
                    case "-6":
                    case "6-":
                        AddGrade(95f);
                        break;
                    default:
                        throw new Exception("unexpected grade");
                }
            }

            else if (float.TryParse(grade, out float result))
            {
                if (result >= 1 && result <= 6)
                {
                    switch (result)
                    {
                        case 1:
                            AddGrade(0f);
                            break;
                        case 2:
                            AddGrade(20f);
                            break;
                        case 3:
                            AddGrade(40f);
                            break;
                        case 4:
                            AddGrade(60f);
                            break;
                        case 5:
                            AddGrade(80f);
                            break;
                        case 6:
                            AddGrade(100f);
                            break;
                        default:
                            throw new Exception("unexpected grade (range 1-6)");
                    }
                }
                else
                {
                    throw new Exception("unexpected grade (range 1-6)");
                }
            }
            else
            {
                throw new Exception("unexpected grade");
            }
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"invalid grade value: {grade}. Value not added.");
            }
        }
        public override void AddGrade(double grade)
        {
            string gradeValue = grade.ToString();
            AddGrade(gradeValue);
        }

        public override void AddGrade(int grade)
        {
            string gradeValue = grade.ToString();
            AddGrade(gradeValue);
        }

        public override void AddGrade(long grade)
        {
            string gradeValue = grade.ToString();
            AddGrade(gradeValue);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
