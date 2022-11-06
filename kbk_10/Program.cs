//Console.WriteLine("Введите размер масива: ");
//int n = int.Parse(Console.ReadLine());
//double[] mas1 = new double[n];
//double[] mas2 = new double[n];
//Random random = new Random();
//for (int i = 0; i < n; i++)
//{
//    mas1[i] = random.NextDouble() * 90 + 10;
//    Console.WriteLine($"{mas1[i]:F2} ");
//}
//Console.WriteLine();
//for (int i = 0; i < n; i++)
//{
//    mas2[i] = random.NextDouble() * 90 + 10;
//    Console.WriteLine($"{mas2[i]:F2} ");

//}

//Console.WriteLine();
//double max1 = mas1[0], max2 = mas2[0];
//int index1 = 0, index2 = 0;
//for (int i = 0; i < n; i++)
//{

//    if (mas1[i] > max1)
//    {
//        max1 = mas1[i];
//        index1 = i;
//    }

//    if (mas2[i] > max2)
//    {
//        max2 = mas2[i];
//        index2 = i;
//    }
//}

//double temp = mas1[index1];
//mas1[index1] = mas2[index2];
//mas2[index2] = temp;


//int[] mas = new int[3];
//string[] sa = new string[3];
//Random r = new Random();

//for (int i = 0;i<3; i++)
//{
//    mas[i] = r.Next(10, 100);
//    Console.WriteLine(mas[i]+" ");
//}

//Console.WriteLine();
//for (int i = 0; i<3; i++)
//{
//    sa[i] = Convert.ToString(mas[i], 2);
//    Console.WriteLine(sa[i]+ "  ");

//}


//Лабораторная работа 4.1 Высокий
Console.WriteLine("Введите число: ");
int number =  int.Parse(Console.ReadLine());
string BinaryNumber = Convert.ToString(number, 2);
int LimitLong = BinaryNumber.Length;
char[] mas = new char[LimitLong];
char[] newmas = new char[LimitLong];
for (int i = 0; i<LimitLong; i++)
{
    mas[i] = BinaryNumber[i];
    Console.Write(mas[i]);
}

Console.WriteLine();

for (int i = 0; i < LimitLong; i++)
{
    if (i + 2 < LimitLong)
        newmas[i + 2] = mas[i];
    else
        if ((i + 1) < LimitLong)
        newmas[LimitLong - i - 2] = mas[i];
        else
        newmas[LimitLong - i] = mas[i];
}

string SecondBinaryNumber = new string(newmas);
Console.WriteLine($"Первое число в двоичном коде:{BinaryNumber}\n" +
                  $"Второе число в двоинчном коде:{SecondBinaryNumber}");

int SecondNumber = Convert.ToInt32(SecondBinaryNumber, 2);
Console.WriteLine($"Первое число :{number}\n" +
                  $"Второе число :{SecondNumber}\n");

int TotalAnswer = number - SecondNumber;
Console.WriteLine($"Разница между первым и вторым числом составляет: " +
                  $"{TotalAnswer}");
