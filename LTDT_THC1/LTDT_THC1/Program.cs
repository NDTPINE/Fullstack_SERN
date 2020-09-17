using System;
using System.IO;

namespace LTDT_THC1
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
        static bool CheckGrap(int[,] arr, int n)
        {
            bool result = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] != arr[j, i]) return false;
                }
            }
            return result;
        }
        static int CheckLoop(int[,] arr, int n)
        {
            int countcloop = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] != 0 && i == j) countcloop++;
                }
            }
            return countcloop;
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
            if (!CheckGrap(arr, n)) return count;
            return (count + CheckLoop(arr, n)) / 2;
        }
        static int CountEdgeMultiple(int[,] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] >= 2)
                    {
                        count++;
                    };
                }
            }
            if (!CheckGrap(arr, n)) return count;
            return count / 2;
        }
        static int[,] CountDegreeScalar(int[,] arr, int n) //bac do thi vo huong
        {
            int[,] count = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        count[i, 0] += arr[i, j];
                        count[i, 1] += arr[j, i];
                    }
                    count[i, 0] += arr[i, j];
                    count[i, 1] += arr[j, i];
                }
            }
            return count;
        }
        static int[,] CountDegreeDirected(int[,] arr, int n) //bac do thi co huong
        {
            int[,] count = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    count[i, 0] += arr[i, j];
                    count[i, 1] += arr[j, i];
                }
            }
            return count;
        }
        static int CountPendantVertex(int[,] arr, int n)
        {
            int result = 0;
            int[,] count;
            if (CheckGrap(arr, n)) //do thi vo huong
            {
                count = CountDegreeScalar(arr, n);
                for (int i = 0; i < n; i++)
                {
                    if ((count[i, 0] + count[i, 1]) / 2 == 1) result++;
                }
            }
            else // do thi co huong
            {
                count = CountDegreeDirected(arr, n);
                for (int i = 0; i < n; i++)
                {
                    if ((count[i, 0] + count[i, 1]) == 1) result++;
                }
            }
            return result;
        }
        static int CountIsolatedVertex(int[,] arr, int n)
        {
            int result = 0;
            int[,] count;
            if (CheckGrap(arr, n)) //do thi vo huong
            {
                count = CountDegreeScalar(arr, n);
                for (int i = 0; i < n; i++)
                {
                    if ((count[i, 0] + count[i, 1]) / 2 == 0) result++;
                }
            }
            else // do thi co huong
            {
                count = CountDegreeDirected(arr, n);
                for (int i = 0; i < n; i++)
                {
                    if ((count[i, 0] + count[i, 1]) == 0) result++;
                }
            }
            return result;
        }
        static void PrintDegree(int[,] arr, int n)
        {
            int[,] count;
            for (int i = 0; i < n; i++)
            {
                if (CheckGrap(arr, n)) //do thi vo huong
                {
                    count = CountDegreeScalar(arr, n);
                    Console.Write($"{i}({(count[i, 0] + count[i, 1]) / 2}) ");
                }
                else // do thi co huong
                {
                    count = CountDegreeDirected(arr, n);
                    Console.Write($"{i}({count[i, 1]}-{count[i, 0]}) ");
                }
            }
            Console.WriteLine();
        }
        static void PrintTypeGrap(int[,] arr, int n)
        {
            if (CheckGrap(arr, n)) //do thi vo huong
            {
                if (CheckLoop(arr, n) > 0) Console.WriteLine("Gia do thi");
                else if (CountEdgeMultiple(arr, n) > 0) Console.WriteLine("Da do thi");
                else Console.WriteLine("Don do thi");
            }
            else //do thi co huong
            {
                if (CountEdgeMultiple(arr, n) > 0) Console.WriteLine("Da do thi co huong");
                else Console.WriteLine("Do thi co huong");
            }
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
            Console.WriteLine($"{n}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            if (CheckGrap(arr, n)) Console.WriteLine("Do thi vo huong");
            else Console.WriteLine("Do thi co huong");
            Console.WriteLine($"So dinh cua do thi: {n}");
            Console.WriteLine($"So canh cua do thi: {CountEdge(arr, n)}");
            Console.WriteLine($"So cap dinh xuat hien cap boi: {CountEdgeMultiple(arr, n)}");
            Console.WriteLine($"So canh khuyen: {CheckLoop(arr, n)}");
            Console.WriteLine($"So dinh treo: {CountPendantVertex(arr, n)}");
            Console.WriteLine($"So dinh co lap: {CountIsolatedVertex(arr, n)}");
            Console.WriteLine("Bac cua tung dinh:");
            PrintDegree(arr, n);
            PrintTypeGrap(arr, n);
            Console.ReadKey();
        }
    }
}
