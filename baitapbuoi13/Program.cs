namespace baitapbuoi13;
internal class Program
{
    #region Student
    // private static void AddStudent(StudentManager manager)
    // {
    //     try
    //     {
    //         Console.Write("Nhập mã học sinh: ");
    //         string code = Console.ReadLine();

    //         Console.Write("Nhập tên học sinh: ");
    //         string name = Console.ReadLine();

    //         Console.Write("Nhập điểm Toán: ");
    //         double math = double.Parse(Console.ReadLine());

    //         Console.Write("Nhập điểm Văn: ");
    //         double literature = double.Parse(Console.ReadLine());

    //         Console.Write("Nhập điểm Anh: ");
    //         double english = double.Parse(Console.ReadLine());

    //         Student student = new Student(code, name, math, literature, english);
    //         manager.addStudent(student);
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"Lỗi: {ex.Message}");
    //     }
    // }

    // private static void SearchStudent(StudentManager manager)
    // {
    //     Console.Write("Nhập tên học sinh cần tìm: ");
    //     string name = Console.ReadLine();
    //     manager.SearchStudentByName(name);
    // }

    // private static void UpdateScores(StudentManager manager)
    // {
    //     try
    //     {
    //         Console.Write("Nhập mã học sinh: ");
    //         string code = Console.ReadLine();

    //         Console.Write("Nhập điểm Toán mới: ");
    //         double math = double.Parse(Console.ReadLine());

    //         Console.Write("Nhập điểm Văn mới: ");
    //         double literature = double.Parse(Console.ReadLine());

    //         Console.Write("Nhập điểm Anh mới: ");
    //         double english = double.Parse(Console.ReadLine());

    //         manager.UpdateStudentScore(code, math, literature, english);
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"Lỗi: {ex.Message}");
    //     }
    // }

    // private static void RemoveStudent(StudentManager manager)
    // {
    //     Console.Write("Nhập mã học sinh cần xóa: ");
    //     string code = Console.ReadLine();
    //     manager.RemoveStudent(code);
    // }

    // private static void Main(string[] args)
    // {
    //     StudentManager studentManager = new StudentManager();

    //     while (true)
    //     {
    //         Console.WriteLine("\n===== QUẢN LÝ HỌC SINH =====");
    //         Console.WriteLine("1. Thêm học sinh");
    //         Console.WriteLine("2. Tìm kiếm học sinh theo tên");
    //         Console.WriteLine("3. Cập nhật điểm học sinh");
    //         Console.WriteLine("4. Xóa học sinh");
    //         Console.WriteLine("5. Hiển thị học sinh theo xếp loại học lực");
    //         Console.WriteLine("6. Hiển thị học sinh theo điểm trung bình (tăng dần)");
    //         Console.WriteLine("7. Hiển thị học sinh theo tên (dựa vào chữ cái cuối)");
    //         Console.WriteLine("8. Thoát chương trình");
    //         Console.Write("Chọn chức năng (1-8): ");

    //         string option = Console.ReadLine();

    //         switch (option)
    //         {
    //             case "1":
    //                 AddStudent(studentManager);
    //                 break;
    //             case "2":
    //                 SearchStudent(studentManager);
    //                 break;
    //             case "3":
    //                 UpdateScores(studentManager);
    //                 break;
    //             case "4":
    //                 RemoveStudent(studentManager);
    //                 break;
    //             case "5":
    //                 studentManager.DisplayStudentsByClassification();
    //                 break;
    //             case "6":
    //                 studentManager.DisplayStudentsByAverageScore();
    //                 break;
    //             case "7":
    //                 studentManager.DisplayStudentsByName();
    //                 break;
    //             case "8":
    //                 Console.WriteLine("Thoát chương trình...");
    //                 return;
    //             default:
    //                 Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
    //                 break;
    //         }
    //     }
    // }
    #endregion
    #region Product
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager();

        while (true)
        {
            Console.WriteLine("\n===== QUẢN LÝ SẢN PHẨM =====");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Tìm kiếm sản phẩm theo tên");
            Console.WriteLine("3. Cập nhật giá và số lượng tồn kho");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Hiển thị danh sách sản phẩm");
            Console.WriteLine("6. Hiển thị sản phẩm theo giá (tăng dần/giảm dần)");
            Console.WriteLine("7. Hiển thị sản phẩm theo tên (sắp xếp theo từ cuối)");
            Console.WriteLine("8. Tính tổng giá trị kho hàng");
            Console.WriteLine("9. Thoát");
            Console.Write("Chọn chức năng: ");

            string choice = Console.ReadLine();
            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Nhập mã sản phẩm: ");
                        string code = Console.ReadLine();
                        Console.Write("Nhập tên sản phẩm: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhập giá: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Nhập số lượng tồn kho: ");
                        int stock = int.Parse(Console.ReadLine());
                        productManager.AddProduct(new Product(code, name, price, stock));
                        break;

                    case "2":
                        Console.Write("Nhập tên sản phẩm: ");
                        string searchName = Console.ReadLine();
                        var results = productManager.SearchByName(searchName);
                        results.ForEach(Console.WriteLine);
                        break;

                    case "3":
                        Console.Write("Nhập mã sản phẩm: ");
                        string updateCode = Console.ReadLine();
                        Console.Write("Nhập giá mới: ");
                        double newPrice = double.Parse(Console.ReadLine());
                        Console.Write("Nhập số lượng mới: ");
                        int newStock = int.Parse(Console.ReadLine());
                        productManager.UpdateProduct(updateCode, newPrice, newStock);
                        break;

                    case "4":
                        Console.Write("Nhập mã sản phẩm: ");
                        string removeCode = Console.ReadLine();
                        productManager.RemoveProduct(removeCode);
                        break;

                    case "5":
                        productManager.DisplayAllProducts();
                        break;

                    case "6":
                        Console.Write("Hiển thị giá tăng dần (true) hay giảm dần (false): ");
                        bool ascending = bool.Parse(Console.ReadLine());
                        var sortedProducts = productManager.GetProductsSortedByPrice(ascending);
                        sortedProducts.ForEach(Console.WriteLine);
                        break;

                    case "7":
                        var nameSortedProducts = productManager.GetProductsSortedByName();
                        nameSortedProducts.ForEach(Console.WriteLine);
                        break;

                    case "8":
                        Console.WriteLine($"Tổng giá trị kho hàng: {productManager.CalculateTotalValue():F2}");
                        break;

                    case "9":
                        Console.WriteLine("Thoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("Chọn không hợp lệ!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
    #endregion
}
