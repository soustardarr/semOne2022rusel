using System;
using System.Text;

namespace ConsoleApp8
{
    class Program
    {
        public static int[] GetBenfordStatistics(string text)
        {
            var statistics = new int[10];
            foreach (var word in text.Split(" "))
            {
                for (int i = 0; i < 10; i++)
                {
                    if (char.IsDigit(word[0]) && word[0].ToString() == i.ToString()) { statistics[i]++; }
                }
            }
            
            return statistics;
        }


        public static string ReplaceIncorrectSeparators(string text)
        {
            char[] symb = { ' ', '-', ';', ':', ',' };
            return String.Join("\t", (text.Split(symb, StringSplitOptions.RemoveEmptyEntries)));
        }

        private static string ApplyCommands(string[] commands)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < commands.Length; i++)
            { 
                if (commands[i].StartsWith("push"))
                    sb.Append(commands[i].Remove(0, 5));
                else if (commands[i].StartsWith("pop"))
                {
                    int a = Convert.ToInt32(commands[i].Remove(0, 4));
                    sb.Remove(sb.Length - a, a);
                }
            }
            return sb.ToString();
        }


        public static void Main()
        {
            {
                Console.WriteLine(Encoding.UTF8.GetBytes("БЩФzw!").Length);
            }

        }
    }
}