namespace Session11
{
    public class Classroom
    {
        public string classId;
        public string className;
        public List<Student> students;

        public Classroom(string classId, string className)
        {
            this.classId = classId;
            this.className = className;
            this.students = [];
        }

        public void addStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine($"Student {student.studentName} added to class {className}");
        }

        public void showStudent()
        {
            Console.WriteLine($"\n =======Student in class {className}=======");
            foreach (Student student in students)
            {
                student.displayInfo();
            }
        }

        public void findStudentByStudentId(string studentId)
        {
            foreach (Student student in students)
            {
                if (student.studentId == studentId)
                {
                    student.displayInfo();
                    return;
                }
            }
            Console.WriteLine($"Student with ID {studentId} not found in class {className}");
        }
    }
}