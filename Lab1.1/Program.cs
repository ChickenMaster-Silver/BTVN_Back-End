//Bai1:
Console.Write("Nhap ten cua ban: ");
string name = Console.ReadLine();
Console.Write("Nhap tuoi cua ban: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Xin chao {name}, ban {age} tuoi!");

//Bai2:
double Dientich = 0;
Console.Write("Nhap chieu dai cua hinh chu nhat: ");
double Chieudai = double.Parse(Console.ReadLine());
Console.Write("Nhap chieu rong cua hinh chu nhat: ");
double Chieurong = double.Parse(Console.ReadLine());

if (Chieudai > Chieurong && Chieudai >0 && Chieurong > 0)
{
    Dientich = Chieudai * Chieurong;
    Console.Write($"Dien tich: {Dientich}");
}
else 
{
    Console.Write("Moi ban nhap lai !!!");
}

//Bai3
Console.Write("Nhập nhiệt độ C: ");
double DoC = double.Parse(Console.ReadLine());
double DoF = DoC * 9 / 5 + 32;
Console.WriteLine($"{DoC}°C = {DoF}°F");

//Bai4
Console.Write("Nhập số nguyên: ");
int So = int.Parse(Console.ReadLine());
Console.WriteLine(So % 2 == 0 ? "Là số chẵn" : "Không phải số chẵn");

//Bai5
Console.Write("Nhập số thứ nhất: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Nhập số thứ hai: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine($"Tổng: {a + b}, Tích: {a * b}");

//Bai6
Console.Write("Nhập một số: ");
double number = double.Parse(Console.ReadLine());
if (number > 0) Console.WriteLine("Số dương");
else if (number < 0) Console.WriteLine("Số âm");
else Console.WriteLine("Số không");

//Bai7
Console.Write("Nhập năm: ");
int year = int.Parse(Console.ReadLine());
bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
Console.WriteLine(isLeap ? "Năm nhuận" : "Không phải năm nhuận");

//Bai8
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//Bai9
Console.Write("Nhập n: ");
int n = int.Parse(Console.ReadLine());
long factorial = 1;
for (int i = 2; i <= n; i++) factorial *= i;
Console.WriteLine($"{n}! = {factorial}");

//Bai10
Console.Write("Nhập số: ");
int num = int.Parse(Console.ReadLine());
bool isPrime = true;

if (num < 2) isPrime = false;
else
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

Console.WriteLine(isPrime ? "Là số nguyên tố" : "Không phải số nguyên tố");


