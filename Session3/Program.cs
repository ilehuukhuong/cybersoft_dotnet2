#region if-else statement
//nhâpj số nguyên từ bàn phím và in ra số đó là số lẻ hay số chẵn
// Console.Write("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);

// if (formatNumber % 2 == 0)
// {
//     Console.WriteLine($"Số {number} là số chẵn");
// }
// else
// {
//     Console.WriteLine($"Số {number} là số lẻ");
// }

#endregion

#region Tính tổng ba ký số
// int number;
// nhapdulieu:
// Console.Write("Mời bạn nhập số có 3 chữ số: ");
// string? inputValue = Console.ReadLine();
// if (inputValue == null)
// {
//     Console.WriteLine("Vui lòng nhập vào thông tin!");
//     goto nhapdulieu;
// }
// else
// {
//     try
//     {
//         number = Convert.ToInt16(inputValue);
//     }
//     catch
//     {
//         Console.WriteLine("Vui lòng nhập vào số có ba chữ số!");
//         goto nhapdulieu;
//     }
//     if (number < 100 || number > 999)
//     {
//         Console.WriteLine("Vui lòng nhập vào số có ba chữ số!");
//         goto nhapdulieu;
//     }
//     else
//     {
//         int a;
//         int b;
//         int c;
//         a = number / 100;
//         b = (number - a * 100) / 10;
//         c = number % 10;
//         Console.WriteLine($"Tổng ba ký số là {a + b + c}");
//     }
// }
#endregion

#region Nhập ngày (đ/mm/yyyy). In ra thứ mấy trong tuần

#endregion


// switch...case
// c1: dùng switch...case
// nhập số có trong khoảng từ 1 đến 10. Đọc số
string? number2 = Console.ReadLine();
int formatNumber2 = Convert.ToInt32(number2);
switch (formatNumber2)
{
    case 1:
        Console.WriteLine("Số 1");
        break;
    case 2:
        Console.WriteLine("Số 2");
        break;
    case 3:
        Console.WriteLine("Số 3");
        break;
    case 4:
        Console.WriteLine("Số 4");
        break;
    case 5:
        Console.WriteLine("Số 5");
        break;
    case 6:
        Console.WriteLine("Số 6");
        break;
    default:
        Console.WriteLine("Số 10");
        break;
}

// c2: switch expression

