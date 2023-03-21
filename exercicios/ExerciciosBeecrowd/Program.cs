//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int maiorAB = 0;
//int maiorFinal = 0;

//void MaiorAB(int a, int b)
//{
//    maiorAB = (a + b + Math.Abs(a-b))/2;
//}

//void MaiorFinal(int maiorab, int c)
//{
//    maiorFinal = (maiorab + c + Math.Abs(maiorab - c)) / 2;
//}

//MaiorAB(a, b);

//MaiorFinal(maiorAB, c);

//Console.WriteLine($"{maiorFinal} eh o maior");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int maiorAB = (a + b + Math.Abs(a - b)) / 2;
int maiorFinal = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

Console.WriteLine($"{maiorFinal} eh o maior");