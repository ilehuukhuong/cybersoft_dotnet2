namespace baitapbuoi13
{
    public class Student
    {
        public Student(string studentCode, string studentName, double mathScore, double literatureScore, double englishScore)
        {
            this.studentCode = studentCode;
            this.studentName = studentName;
            this.mathScore = mathScore;
            this.literatureScore = literatureScore;
            this.englishScore = englishScore;
        }
        private string studentCode;
        public string StudentCode
        {
            get { return studentCode; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student code is invalid");
                }
                studentCode = value;
            }
        }

        private string studentName;
        public string StudentName
        {
            get { return studentName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student name cannot be empty");
                }
                studentName = value;
            }
        }

        private double mathScore;
        public double MathScore
        {
            get { return mathScore; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Math score must be between 0 and 10");
                }
                mathScore = value;
            }
        }

        private double literatureScore;
        public double LiteratureScore
        {
            get { return literatureScore; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Literature score must be between 0 and 10");
                }
                literatureScore = value;
            }
        }

        private double englishScore;
        public double EnglishScore
        {
            get { return englishScore; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("English score must be between 0 and 10");
                }
                englishScore = value;
            }
        }

        public double AverageScore => (MathScore + LiteratureScore + EnglishScore) / 3;

        public string Classification
        {
            get
            {
                if (AverageScore < 5) return "Yếu";
                if (AverageScore < 6.5) return "Trung bình";
                if (AverageScore < 8) return "Khá";
                return "Giỏi";
            }
        }
    }
}
