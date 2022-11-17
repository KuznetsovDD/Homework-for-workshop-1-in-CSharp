Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
if(a<=0)
{
   while(i>a-1)
{
    if (i%2==0)
    Console.Write(i + " ");
    i =i-1; 
}}
else{
while(i<a+1)
{
    if (i%2==0)
    Console.Write(i + " ");
    i ++;
}
}