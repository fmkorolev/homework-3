//задача 23
/*
void tableofnumbers(int N)
{
    int count = 1;
    Console.Write(N + "-> ");
    while(count <= N)
    {
        Console.Write(count * count * count + " ");
        count++;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0)
    tableofnumbers(num);
else
    Console.Write("Input positive number");

*/

// задача 19
/*
Console.Write("Input a five-digit number: ");
int Num = Convert.ToInt32(Console.ReadLine());
void Palindrome(int num)
{
    Console.Write(num + " -> ");
    int xa = num;
    int xb = 0;
    while(num > 0)
    {
        xb = xb * 10 + num % 10;
        num = num / 10;
    
    }
    if(xa == xb)
        Console.Write("Palindrome");
    else
        Console.Write("Not a palindrome");    
}
Palindrome(Num);
*/

// Задача 21


double Distance(double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}
Console.Write("Input the coordinates X of the first point: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates Y of the first point: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates Z of the first point: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates X of the second point: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates Y of the second point: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates Z of the second point: ");
double z2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Distance between points: " + Distance(x1, y1, x2, y2, z1, z1));






