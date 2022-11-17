Console.Write("Введите чесло 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чесло 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чесло 3: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a==b&b==c)
{
    Console.WriteLine("Числа равны");
}
else
{
int max = a;
if( max<b )
    max=b;
if( max<c )
    max=c;

Console.WriteLine("max" + " " + max);
}