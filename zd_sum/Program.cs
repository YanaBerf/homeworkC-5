Console.Clear();
Console.Write("enter number: ");
int num = int.Parse(Console.ReadLine());

int GetNumSum(int n)
{   int sum = 0;
    while(n > 0)
    {
        int  ostatok = n % 10;
        n = n / 10;
        sum = sum + ostatok;
    }
    return sum;  
}
Console.WriteLine(GetNumSum(num));