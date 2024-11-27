using Newtonsoft.Json;
using Session11;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Bài 1: quản lý lớp học
        // 1. Lớp học
        // tạo lớp classroom để quản lý lớp học
        // classId: mã lớp học
        // className: tên lớp học
        // danh sách sinh viên trong lớp
        // 2. Sinh viên
        // studentId: mã sinh viên
        // studentName: tên sinh viên
        // age: tuổi
        // 3. Yêu cầu chức năng
        // - Thêm sinh viên vào lớp
        // - Hiển thị danh sách sinh viên
        // - Tìm sinh viên theo mã sinh viên

        // Tạo lớp học
        Classroom classroom = new Classroom("C02", "Dotnet 02");

        while (true)
        {
            Console.WriteLine("\n ----------Classroom Management----------");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show student");
            Console.WriteLine("3. Find student by student ID");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter your choice (1~4): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter student ID: ");
                    string studentId = Console.ReadLine();
                    Console.WriteLine("Enter student name: ");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("Enter student age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Student student = new(studentId, studentName, age);

                    classroom.addStudent(student);

                    // chuyển thành json
                    var json = JsonConvert.SerializeObject(classroom.students, Formatting.Indented);

                    File.WriteAllText("students.json", json);
                    Console.WriteLine("Add student successfully");
                    break;
                case 2:
                    var studentsJson = File.ReadAllText("students.json");

                    classroom.students = JsonConvert.DeserializeObject<List<Student>>(studentsJson);

                    classroom.showStudent();
                    break;
                case 3:
                    Console.Write("Enter student ID to find: ");
                    string id = Console.ReadLine();
                    classroom.findStudentByStudentId(id);
                    break;
                case 4: return;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1~4");
                    break;
            }
        }
    }
}