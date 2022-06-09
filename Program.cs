int N, M, sum=0;
Console.Write("Введите N: ");
N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите M: ");
M = Convert.ToInt16(Console.ReadLine());
for (int i = N; i <= M; i++)
    sum += i;
Console.WriteLine(sum);