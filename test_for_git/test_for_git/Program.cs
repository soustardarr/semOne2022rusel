
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Diagnostics.CodeAnalysis;
using System.Text;
//static bool isprost(int number)
//{
//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//            return false;
//    }
//    return true;
//}

//List<int> deliteli = new List<int>();
//int n = 37;
//int b = Convert.ToInt32(Math.Pow(n, 0.5));
//for (int i = 2; i < b; i++)
//{
//    if (b % i == 0)
//    {
//        if (isprost(i))
//        {
//            deliteli.Add(i);
//        }
//        if (isprost(b / i))
//        {
//            int c = b / i;
//            deliteli.Add(c);
//        }
//    }

//}
//foreach (var item in deliteli)
//{
//    Console.WriteLine(item);
//}
//double x = double.Parse(Console.ReadLine());
//double y = double.Parse(Console.ReadLine());
//if ((y <= 1 && y >= 0 && Math.Abs(x) <= 1) && (Math.Abs(x) + Math.Abs(y) <= 1))
//{
//    Console.WriteLine("принадлежит");
//}
//else if (Math.Abs(x) <= 1 && ((y >= -1 * x * x) && (y < 0)))
//{
//    Console.WriteLine("принадлежит");

//}
//else
//{
//    Console.WriteLine("не принадлежит");
//}


//NOD and NOK
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int nod = -10000000;
//int i = 100000;
//while (i != 0)
//{
//    if ((a % i == 0) && (b % i == 0))
//    {
//        if (i > nod)
//        {
//            nod = i;
//        }
//    }
//    i--;
//}

//Console.WriteLine(nod);

//int NOK(int n1, int n2)
//{
//    return n1 * n2 / nod;
//}

//Console.WriteLine(NOK(a,b));


//static bool isprost(int a)
//{
//    for (int i = 2; i < a; i++)
//    {
//        if (a % i != 0)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//zdzddzdzddzdzd
//int n = Convert.ToInt32(Console.ReadLine());
//int[,] arr = new int[,]
//{
//    { 0,0 },
//    { 0,0 }
//};
//int[,] arr2 = new int[,]
//{
//    { 1,2 },
//    { 3,4 }
//};

//int p = 1;
//while (n != p)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            for (int k = 0; k < arr.GetLength(0); k++)
//            {
//                arr[i, j] += arr2[i, k] * arr2[k, j];
//            }
//        }
//    }
//    p++;
//}

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write(arr[i, j] + "\t");
//    }
//    Console.WriteLine();
//}



//int[] arr = new int[] { 20, 30, 150, 200 };

//int minValue = arr[0];
//int indMinV = 0;
//int maxValue = arr[0]; 
//int indMaxV = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < minValue)
//    {
//        minValue = arr[i];
//        indMinV = i;
//    }

//    if (arr[i] > maxValue)
//    {
//        maxValue = arr[i];
//        indMaxV = i;
//    }
//}
//int suma = 0;
//if (indMaxV > indMinV)
//{
//    for (int i = indMinV + 1; i < indMaxV; i++)
//        suma += arr[i];
//}
//else
//{
//    for (int i = indMaxV + 1; i < indMinV; i++)
//    {
//        suma += arr[i];
//    }
//}
//Console.WriteLine(suma);



//List<int> lst = new List<int>();
//var n = 6;

//for (int i = 0; i < n; i++)
//{
//    lst.Add(i);
//}
//lst.Remove(lst[3]);

//foreach (var item in lst)
//{
//    Console.WriteLine(item);
//}

//static bool IsPalindrom(char[] word)
//{
//    for (int i = 0; i < word.Length / 2; i++)
//        if (word[i] != word[word.Length - 1 - i])
//        { 
//            return false;
//        }
//    return true;
//} 
//string str = "setes dfdkmfmdkfmkdmfkdmfkmdkmd tet eyeye abcd";

//foreach (string item in str.Split(" "))
//{
//    if (IsPalindrom(item.ToCharArray()))
//    {
//        Console.WriteLine(item);
//    }

//}


//КОНТРОЛЬНАЯ РАБОТА





string path = @"C:\\Users\\rusla\\source\\repos\\soustardarr\\semOne2022rusel\\test_for_git\\test_for_git\\bin\\Debug\\net6.0";
int N = 5;
int[,] matrix = new int[N, N];
matrix = GenerateMatrix(N);
Print(matrix);
WriterInFile(matrix, path);
Print(ReadInFile(path, N));


int[,] GenerateMatrix(int n)
{
    Random r = new Random();

    int[,] matr = new int[n, n];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            matr[i, j] = r.Next(-100, 100);

    return matr;
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

async void WriterInFile(int[,] matrix, string path)
{
    string text = "";
    int N = matrix.GetLength(0);
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            text += matrix[i, j].ToString();
            text += " ";
        }
        text.Trim();
        text += '\n';
    }
    using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
    {
        byte[] buffer = Encoding.Default.GetBytes(text);
        await fstream.WriteAsync(buffer, 0, buffer.Length);
    }
}

int[,] ReadInFile(string path, int n)
{
    using (StreamReader reader = new StreamReader("note.txt"))
    {
        int[,] matr = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            var row = reader.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
                matr[i, j] = int.Parse(row[j]);
        }
        return matr;
    }
}










//int[,] GenerateMatrix(int n)
//{
//    int[,] matr = new int[n, n];
//    Random random = new Random();
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < n; j++)
//        {
//            matr[i, j] = random.Next(-10,10) ;
//        }
//    }
//    return matr;
//}
//int[,] matr = GenerateMatrix(2);

//void WriterInFile(int[,] matr, string file)
//{
//    int n = matr.Length;
//    using (StreamWriter writer = new StreamWriter(file))
//    {
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//                writer.Write("{0} ", matr[i, j]);
//            writer.WriteLine();
//        }
//    }
//}
//WriterInFile(matr, path);

//int[,] ReaderInFile(string file, int n)
//{
//    using StreamReader reader = new StreamReader(file);
//    int[,] matr = new int[n, n];
//    for (int i = 0; i < n; i++)
//    {
//        string[] s = reader.ReadLine().Split(" ");
//        for (int j = 0; j < n; j++)
//        {
//            matr[i, j] = int.Parse(s[j]);
//        }

//    }
//    return matr;
//}

//int [,]myMatrix = ReaderInFile(path, 2);

//void Print(int[,] matr)
//{
//    int n = matr.Length;
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < n; j++)
//        {
//            Console.Write($"{matr[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//}


//Print(myMatrix);