Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");

Console.WriteLine("Bài 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng");
//__*
//_* *
//__*   *
//_*     *
//*******

Console.WriteLine("Bài 3: Nhập vào số n từ bàn phím. Kiểm tra số đó có phải là số đôi xứng không");
Console.WriteLine("VD: Số 121, 1221, 12321,... là những số đối xứng");

// Console.Write("Mời bạn nhập một số: ");
// var number = Convert.ToInt32(Console.ReadLine());
// for (int i = 2; i <= number; i++)
// {
//     int checkNumber = 0;
//     for (int j = 1; j <= i; j++)
//     {
//         if (i % j == 0) checkNumber++;
//     }
//     if (checkNumber == 2) Console.WriteLine($"{i} là số nguyên tố.");
// }

// Console.WriteLine("Mời bạn nhập chiều cao: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < number; i++)
// {
//     for (int j = 0; j < number - i - 1; j++)
//     {
//         Console.Write(" ");
//     }

//     for (int k = 0; k < 2 * i + 1; k++)
//     {
//         if (k == 0 || k == 2 * i || i == number - 1) Console.Write("*");
//         else Console.Write(" ");
//     }

//     Console.WriteLine();
// }

// Console.Write("Mời bạn nhập một số: ");
// var number = Convert.ToInt32(Console.ReadLine());
// int reverse = 0;
// int reminder = 0;
// int beginNumber = number;
// while (number > 0)
// {
//     reminder = number % 10;
//     reverse = reverse * 10 + reminder;
//     number = number / 10;
// }
// if (reverse == beginNumber) Console.WriteLine("Đây là số đối xứng");
// else Console.WriteLine("Đây không phải là số đối xứng");