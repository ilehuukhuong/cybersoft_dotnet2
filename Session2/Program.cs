﻿#region Học phép toán cơ bản
// Học +,-,*,/ (chia lấy phần nguyên), % (chia lấy phần dư)
// Khai báo biến
// int add = 5 + 10;
// Console.WriteLine($"Kết quả cộng hai số 5 và 10 là {add}");

// int minus = 100 - 95;
// Console.WriteLine($"Kết quả của phép trừ 100 - 95 là {minus}");

// int multiplication = 2 * 100;
// Console.WriteLine($"Kết quả nhân hai số 2 và 100 là {multiplication}");

// float division = 5 / 2;
// Console.WriteLine($"Kết quả của phép chia 5 / 2 là {division}");

// float remainderOfDivision = 5 % 2;
// Console.WriteLine($"Kết quả của phép chia lấy dư 5 % 2 là {remainderOfDivision}");
#endregion
#region numberic toán tử
// int cong = 0; //định nghĩa biến cong có giá trị mặc định là 0
// cong += 10;
// Console.WriteLine($"Numberic toán tử cộng: {cong}");
#endregion
#region ép kiểu dữ liệu C1: Dùng Convert
//Convert
//Nhập dữ liệu từ bàn phím => Readline(string);
// string? number = Console.ReadLine();
// int convertNumber = Convert.ToInt32(number);
// Console.WriteLine($"Value number: {convertNumber}");
#endregion
#region Tính chỉ số BMI
// while (true)
// {
//     //Input
//     //Chiều cao và cân nặng đc nhập từ bàn phím
//     Console.Write("Mời bạn nhập vào chiều cao (m): ");
//     double userHeight = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Mời bạn nhập vào cân nặng: ");
//     double userWeight = Convert.ToDouble(Console.ReadLine());
//     // Output
//     //In ra chỉ số BMI

//     double bmi = 0.0;

//     //Process
//     //BMI = (chiều cao)/(cân nặng)*(cân nặng)
//     bmi = userWeight / (userHeight * userHeight);
//     Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");
// }
#endregion
#region
//INPUT
// Hãy nhập bán kính hình tròn
Console.WriteLine($"Hãy nhập bán kính vào");

string banKinh = Console.ReadLine();

//Convert String sang Double

double banKinhDouble = Convert.ToDouble(banKinh);


//PROCESS
//Chu vi hình tròn
double chuVi=0.0;
double dienTich = 0.0;
chuVi = 2 * Math.PI * banKinhDouble;

//Diện tích hình tròn

 dienTich = Math.PI * banKinhDouble * banKinhDouble;

//OUTPUT

Console.WriteLine($"Chu vi của hình tròn là {chuVi}");

Console.WriteLine($"Diện tích của hình tròn là {dienTich}");



#endregion