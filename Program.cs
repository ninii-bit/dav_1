//1
Console.WriteLine("pirveli ricxvi: ");
string num1 = Console.ReadLine();
Console.WriteLine("meore ricxvi: ");
string num2 = Console.ReadLine();

Console.WriteLine("switched versia: ");
Convert.ToInt32(num1);
Convert.ToInt32(num2);
int a = Convert.ToInt32(num1);
int b = Convert.ToInt32(num2);
int c = a;
a = b;
b = c;

Console.WriteLine("pirveli ricxvi: " + a);
Console.WriteLine("meore ricxvi: " +  b);


//2
Console.WriteLine("sheiyvanet ricxvi: ");
double num = Convert.ToDouble(Console.ReadLine());
int newNum = Convert.ToInt32(num);

double arasruli = num - newNum;

Console.WriteLine("arasruli nawilia: " + arasruli);

//3
Console.WriteLine("sheiyvanet ricxvii: ");
int ricxvi = Convert.ToInt32(Console.ReadLine());
if (ricxvi > 99 && ricxvi <= 999)
{
    Console.WriteLine("samnishnaa");
}
else
{
    Console.WriteLine("araa samnishna");
}
//4 -?