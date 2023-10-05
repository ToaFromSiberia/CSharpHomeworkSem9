int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}
int sum(int n, int m)
{
  if (n == m) return n;
  else return sum(n + 1, m) + n;
}
int n = Prompt("Введите начальное число: ");
int m = Prompt("Введите конечное число: ");
Console.WriteLine(sum(n, m));