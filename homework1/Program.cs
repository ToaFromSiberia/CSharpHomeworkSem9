int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}
int Countdown(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{Countdown(n, m + 1)}, ");
  return m;
}
int n = Prompt("Введите число: ");
if (n < 1)
{
  Console.WriteLine("Число должно быть положительным.");
  return;
}
Console.WriteLine(Countdown(n, 1));