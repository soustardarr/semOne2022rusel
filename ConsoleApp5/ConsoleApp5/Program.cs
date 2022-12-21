using System;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;





namespace Poxyi
{
    class Program
    {
        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            string key = "";
            for (var i = 0; i < contacts.Count; i++)
            {
                string name = contacts[i].Split(':')[0];
                if (name.Length >= 2)
                    key = name.Substring(0, 2);
                else if (name.Length == 1)
                    key = name.Substring(0, 1);
                else
                    key = ":";
                if (!dictionary.ContainsKey(key))
                    dictionary[key] = new List<string>();
                if (name.Contains(key))
                    dictionary[key].Add(contacts[i]);
            }
            return dictionary;
        }









        public static void Main(string[] args)
        {
            

        }
    }
}







//string path = @"C:\Users\rusla\Downloads\kontr.txt";
//int N = 2;
//int[,] matrix = new int[N, N];


//int[,] GenerateMatrix(int n)
//{
//    Random r = new Random();

//    int[,] matr = new int[n, n];
//    for (int i = 0; i < n; i++)
//        for (int j = 0; j < n; j++)
//            matr[i, j] = r.Next(-100, 100);

//    return matr;
//}

//void Print(int[,] matr)
//{
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//            Console.Write($"{matr[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//}

//async void WriterInFile(int[,] matrix, string path)
//{
//    string text = "";
//    int N = matrix.GetLength(0);
//    for (int i = 0; i < N; i++)
//    {
//        for (int j = 0; j < N; j++)
//        {
//            text += matrix[i, j].ToString();
//            text += " ";
//        }
//        text.Trim();
//        text += '\n';
//    }
//    using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
//    {
//        byte[] buffer = Encoding.Default.GetBytes(text);
//        await fstream.WriteAsync(buffer, 0, buffer.Length);
//    }
//}

//int[,] ReadInFile(string path, int n)
//{
//    using (StreamReader reader = new StreamReader(@"C:\Users\rusla\Downloads\kontr.txt"))
//    {
//        int[,] matr = new int[n, n];
//        for (int i = 0; i < n; i++)
//        {
//            var row = reader.ReadLine().Split(' ');
//            for (int j = 0; j < n; j++)
//                matr[i, j] = int.Parse(row[j]);
//        }
//        return matr;
//    }
//}

//matrix = GenerateMatrix(N);
//Print(matrix);
//WriterInFile(matrix, path);
//Print(ReadInFile(path, N));
//Console.WriteLine();



//bool IsProst(int p)
//{

//    for (int i = 2; i < p; i++)
//    {
//        if (p % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}



//int[,] GenerateProst(int n)
//{
//    int[,] matr = new int[n, n];
//    Random random = new Random();
//    int k;
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < n; j++)
//        {
//            while (true)
//            {
//                k = random.Next(2, 1000001);
//                if (IsProst(k))
//                {
//                    matr[i, j] = k;
//                    break;
//                }
//            }

//        }
//    }
//    return matr;
//}
//int[,] array = GenerateProst(2);
//Print(array);
//Console.WriteLine();


//int[] GetMinMax(int[,] matr)
//{


//    int minValue = int.MaxValue;
//    int maxValue = int.MinValue;
//    for (int i = 0; i < 2; i++)
//    {
//        for (int j = 0; j < 2; j++)
//        {
//            if (matr[i, j] >= maxValue)
//            {
//                maxValue = matr[i, j];
//            }
//            else if (matr[i, j] <= minValue)
//            {
//                minValue = matr[i, j];
//            }
//        }

//    }
//    int[] minAndMax = new int[] {minValue, maxValue};

//    return minAndMax;
//}



//void pomenaLines(int[,] matr)
//{
//    int maxStr = 0;
//    int minStr = 0;
//    int minValue = int.MaxValue;
//    int maxValue = int.MinValue;
//    for (int i = 0; i < 2; i++)
//    {
//        for (int j = 0; j < 2; j++)
//        {
//            if (matr[i, j] >= maxValue)
//            {
//                maxValue = matr[i, j];
//            }
//            else if (matr[i, j] <= minValue)
//            {
//                minValue = matr[i, j];
//            }
//        }

//    }
//    int[] minAndMax = new int[] { minValue, maxValue };
//    int max = minAndMax[1];
//    int min = minAndMax[0];
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//            if (matr[i, j] == max)
//            {
//                maxStr = i;
//            }
//            if (matr[i, j] == min)
//            {
//                minStr = i;
//            }
//        }
//    }
//    for (int i = 0; i < matr.GetLength(1); i++)
//    {
//        var tmp = matr[maxStr, i];
//        matr[maxStr, i] = matr[minStr, i];
//        matr[minStr, i] = tmp;
//    }
//}