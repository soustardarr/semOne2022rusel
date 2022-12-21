using System;
using System.Data.SqlTypes;
using System.Reflection.PortableExecutable;

namespace ConsoleApp4
{
    class Programm
    {
        public static void WriteReversed(char[] items, int startIndex = 0)
        {

            
            if (startIndex != items.Length)
            {
                // Выводим в обратном порядке все элементы с индексом больше startIndex
                WriteReversed(items, startIndex + 1);
                // а потом выводим сам элемент startIndex
                Console.Write(items[startIndex]);
            }
            
           
        }
        

        
        

        static void Main(string[] args)
        {

            var array = new char[] { 'd','2','=' };
            WriteReversed(array);
           


            //using (StreamWriter writer = new StreamWriter(path, false))
            //{
            //    writer.WriteLine(text);
            //    writer.Close();
            //}

            //string[] word;
            //using (StreamReader reader = new StreamReader(path))
            //{
            //    word = reader.ReadLine().Split();
            //}



            //Console.WriteLine("введите строку, чтобы узнать есть ли такое слово в файле :");

            //string line = Console.ReadLine();


            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (line == word[i])
            //    {
            //        Console.WriteLine($"line : {line} слово из Word");
            //    }
            //}




            //using (StreamWriter sw = new StreamWriter(path, false))
            //{
            //    sw.WriteLine(text);
            //    sw.Close();
            //}

            //string str;
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    str = sr.ReadToEnd();
            //}

            //string podstr = Console.ReadLine();
            //if (str.Contains(podstr))
            //    Console.WriteLine("true");
            //Console.WriteLine(str);



            //foreach (var item in word)
            //{
            //    Console.Write(item + " ");
            //}

            //string text = "hello world I am okey okey";
            //string path = @"C:\Users\rusla\source\repos\soustardarr\semOne2022rusel\ConsoleApp3\ru.txt";


            //using (StreamWriter writer = new StreamWriter(path, false))
            //{
            //    writer.Write(text);
            //    writer.Close();
            //}

            //Dictionary<string, int> test = new Dictionary<string, int>();

            //using (StreamReader reader = new StreamReader(path))
            //{
            //    var str = reader.ReadToEnd();
            //    foreach (var item in reader.ReadToEnd().Split().Distinct())
            //    {
            //        test.Add(item, Value);


            //    }


            //string path = "matrix.txt";
            //using (StreamWriter writer = new StreamWriter(path, false))
            //{
            //    writer.WriteLine("2 2");
            //    writer.WriteLine("43 34");
            //    writer.WriteLine("32 32");
            //    writer.Close();
            //}

            //int[,] matr;
            //using (StreamReader reader = new StreamReader("Matrix.txt"))
            //{
            //    var mn = reader.ReadLine().Split(' ');
            //    int m = int.Parse(mn[0]);
            //    int n = int.Parse(mn[1]);

            //    matr = new int[m, n];

            //    for (int i = 0; i < m; i++)
            //    {
            //        var row = reader.ReadLine().Split(' ');
            //        for (int j = 0; j < n; j++)
            //            matr[i, j] = int.Parse(row[j]);
            //    }








            //}


            //for (int i = 0; i < matr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matr.GetLength(1); j++)
            //    {
            //        Console.Write(matr[i, j] + " ");       
            //    }
            //    Console.WriteLine();   
            //}

        }    
            
    }
}