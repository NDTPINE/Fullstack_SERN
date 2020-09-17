using System;
using System.IO;

namespace LTDT_THC2
{
    class Program
    {
        public static int n;
        public static int[,] arr;
        public static void Main(string[] args)
        {

            string str = "input.txt";
            ReadFileInput(str);
            WriteFileOutput(arr, n);
        }
        static int CountEdge(int[,] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] != 0)
                    {
                        count += arr[i, j];
                    };
                }
            }
            return count / 2;
        }
        
        static int[] CountDegreeScalar(int[,] arr, int n) //bac do thi vo huong
        {
            int[] count = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        count[i] += arr[i, j] + arr[j, i];
                    }
                    count[i] += arr[i, j] + arr[j, i];
                }
            }
            return count;
        }
        static bool CheckDegree(int[,] arr, int n)
        {
            bool result = true;
            int[] count = CountDegreeScalar(arr, n);
            int first = count[0];
            for (int i = 1; i < n; i++)
            {
                if (first != count[i])
                {
                    return result = false;
                }
            }
            return result;
        }
        static bool CheckCirleGrap(int[,] arr, int n)
        {
            bool result = true;
            if ((n < 3) || (!CheckDegree(arr, n)) || CountEdge(arr,n) != n) return false;
            return result;
        }

        static void ReadFileInput(string filepath)
        {
            StreamReader file = new StreamReader(filepath);
            n = Int32.Parse(file.ReadLine());
            arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] temp = new string[n];
                temp = file.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    int.TryParse(temp[j], out arr[i, j]);
                }
            }
        }
        static void WriteFileOutput(int[,] arr, int n)
        {
            if (CountEdge(arr, n) == (n * (n - 1) / 2)) Console.WriteLine($"Day la do thi day du K{n}");
            else Console.WriteLine($"Day khong phai la do thi day du");
            int first = CountDegreeScalar(arr, n)[0];
            if (CheckDegree(arr,n)) Console.WriteLine($"Day la do thi {first/2}-chinh quy"); 
            else Console.WriteLine("Day khong phai la do thi chinh quy");
            if (CheckCirleGrap(arr, n)) Console.WriteLine($"Day la do thi vong C{n}");
            else Console.WriteLine("Day khong phai la do thi vong");
            Console.ReadKey();
        }
    }
}
