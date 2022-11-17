Console.Write("Введите чесло 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чесло 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a==b)
{
    Console.WriteLine("Числа равны");

}
else
if(a<b)
{
    Console.WriteLine("max" +  " " + b);
    Console.WriteLine("min" +  " " + a);
}
else
{
    Console.WriteLine("max" +  " " + a);
    Console.WriteLine("min" +  " " + b);
}