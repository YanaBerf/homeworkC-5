Console.Clear();
Console.Write("enter number: ");
double num = double.Parse(Console.ReadLine());
Console.Write("enter number pow: ");
double stepen = double.Parse(Console.ReadLine());

double GetPow(double n, double s)
{
   double numPow = Math.Pow(n, s);
   return numPow;
}

Console.WriteLine($"число {num} в степени {stepen} равно {GetPow(num, stepen)}");