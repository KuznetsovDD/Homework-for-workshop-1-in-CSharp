Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if(a<0)
{
    Console.WriteLine("Неверное число");
}
else
{
int i = 1;
while(i<a+1)
{
    if (i%2==0)
    Console.Write(i + " ");
    i ++;
}
}
