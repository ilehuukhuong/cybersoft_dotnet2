using Newtonsoft.Json;

namespace baitapbuoi13
{
    public class StudentManager
    {
        private List<Student> students;

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        private string filePath = "students.json";

        private void loadData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                Students = JsonConvert.DeserializeObject<List<Student>>(json);
            }
            else
            {
                Students = new List<Student>();
            }
        }

        public StudentManager()
        {
            loadData();
        }

        private void saveDada()
        {
            string json = JsonConvert.SerializeObject(Students, Formatting.Indented);

            File.WriteAllText(filePath, json);
        }

        public void addStudent(Student student)
        {
            Student stu = Students.Find(s => s.StudentCode == student.StudentCode);
            if (stu != null)
            {
                throw new ArgumentException("Mã học sinh đã tồn tại");
            }
            Students.Add(student);
            saveDada();
            Console.WriteLine("Thêm học sinh thành công");
        }

        public void SearchStudentByName(string name)
        {
            var results = students.Where(s => s.StudentName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (results.Any())
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                foreach (var student in results)
                {
                    DisplayStudentInfo(student);
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy học sinh với tên đã nhập vào.");
            }
        }

        public void UpdateStudentScore(string studentCode, double mathScore, double literatureScore, double englishScore)
        {
            var student = students.FirstOrDefault(s => s.StudentCode == studentCode);

            if (student != null)
            {
                student.MathScore = mathScore;
                student.LiteratureScore = literatureScore;
                student.EnglishScore = englishScore;
                Console.WriteLine("Cập nhật điểm học sinh thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy học sinh.");
            }
        }

        public void RemoveStudent(string studentCode)
        {
            var student = students.FirstOrDefault(s => s.StudentCode == studentCode);

            if (student != null)
            {
                students.Remove(student);
                saveDada();
                Console.WriteLine("Xóa học sinh thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy học sinh để xóa.");
            }
        }

        public void DisplayStudentsByClassification()
        {
            Console.WriteLine("Hiển thị danh sách học sinh xếp loại theo học lực:");
            var sortedStudents = students.OrderByDescending(s => s.AverageScore).ToList();

            foreach (var student in sortedStudents)
            {
                DisplayStudentInfo(student);
            }
        }

        public void DisplayStudentsByAverageScore()
        {
            Console.WriteLine("Hiển thị học sinh theo điểm trung bình tăng dần:");
            var sortedStudents = students.OrderBy(s => s.AverageScore).ToList();

            foreach (var student in sortedStudents)
            {
                DisplayStudentInfo(student);
            }
        }

        public void DisplayStudentsByName()
        {
            Console.WriteLine("Hiển thị học sinh theo tên (dựa vào chữ cái cuối):");
            var sortedStudents = students.OrderBy(s => s.StudentName.Split(' ').Last()).ToList();

            foreach (var student in sortedStudents)
            {
                DisplayStudentInfo(student);
            }
        }

        private void DisplayStudentInfo(Student student)
        {
            Console.WriteLine($"Mã: {student.StudentCode}, Tên: {student.StudentName}, " +
                              $"Toán: {student.MathScore}, Văn: {student.LiteratureScore}, " +
                              $"Anh: {student.EnglishScore}, Trung bình: {student.AverageScore:F2}, " +
                              $"Xếp loại: {student.Classification}");
        }
    }
}
