// Сложение двух случайных чисел
int numberA = new Random (). Next (1, 10); // 1 2 3 4 ... 9
Console.Write("число первое - ");
Console.WriteLine(numberA);
int numberB = new Random (). Next (1, 10); // 1 2 3 4 ... 9
Console.Write("число второе - ");
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.Write("сумма        - ");
Console.WriteLine (result);

