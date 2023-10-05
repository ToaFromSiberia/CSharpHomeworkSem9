int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}
int akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return akkerman(m - 1, 1);
  else return akkerman(m - 1, akkerman(m, n - 1));
}
int m = Prompt("Введите начальное число: ");
int n = Prompt("Введите конечное число: ");
Console.WriteLine($"A({m},{n}) = {akkerman(m, n)}");